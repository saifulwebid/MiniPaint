using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniPaint.WinForms.DrawingObject;
using MiniPaint.WinForms.LineGenerator;
using MiniPaint.WinForms.Action;
using MiniPaint.WinForms.Canvas;
using MiniPaint.WinForms.Transformation;

namespace MiniPaint.WinForms
{
    public partial class frmMain : Form
    {
        private List<IAction> actions;
        private Point startPoint;
        private bool dragging;
        private Color objectColor;

        public Color ObjectColor
        {
            get
            {
                return objectColor;
            }
            set
            {
                objectColor = value;
                pbxForegroundObjectColor.BackColor = value;
            }
        }
        public Color AxisColor
        {
            get
            {
                return PolynomialFunctionCanvas.AxisColor;
            }
            set
            {
                PolynomialFunctionCanvas.AxisColor = value;
                pbxAxisColor.BackColor = value;
            }
        }
        internal Canvas.Canvas ActiveCanvas { get; private set; }
        internal DrawingCanvas DrawingCanvas { get; private set; }
        internal PolynomialFunctionCanvas PolynomialFunctionCanvas { get; private set; }
        internal BindingList<IDrawable> GeometryObjects { get; private set; }

        public frmMain()
        {
            InitializeComponent();
            
            actions = new List<IAction>();
            GeometryObjects = new BindingList<IDrawable>();
            dragging = false;

            /* Initialize canvas */
            DrawingCanvas = new DrawingCanvas(pbxCanvas.Width, pbxCanvas.Height);
            PolynomialFunctionCanvas = new PolynomialFunctionCanvas(pbxCanvas.Width, pbxCanvas.Height, Color.Gray);
            ActiveCanvas = DrawingCanvas;
            ActiveCanvas.BitmapChanged += new EventHandler(CanvasChanged);

            ObjectColor = Color.Black;
            AxisColor = Color.Gray;

            /* Wire dgvObjectList with GeometryObjects */
            dgvObjectList.AutoGenerateColumns = false;

            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "ObjectColumn",
                HeaderText = "Object",
                DataPropertyName = "DisplayText" // Tell the column which property of FileName it should use
            };
            dgvObjectList.Columns.Add(col);
            dgvObjectList.DataSource = GeometryObjects;

            GeometryObjects.ListChanged += GeometryObjects_ListChanged;
        }

        private void GeometryObjects_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnTransform.Enabled = GeometryObjects.Count > 0;
        }

        private void CanvasChanged(object sender, EventArgs e)
        {
            pbxCanvas.Invalidate();
        }

        private void pbxCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ActiveCanvas.Bitmap, 0, 0);
        }

        private void pbxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (!rdoToolboxPolynomialFunction.Checked)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
                DrawingCanvas.PrepareForDragging();

                CancelEventArgs c = new CancelEventArgs();
                txtNGonEdges_Validating(txtNGonEdges, c);
                if (c.Cancel == false)
                {
                    txtNGonSkip_Validating(txtNGonEdges, c);
                }
            }
        }

        private void pbxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                DrawingCanvas.FinishDragging();

                IDrawable objectToDraw = getDrawnObject(startPoint, e.Location);
                if (objectToDraw != null)
                {
                    IAction a = new CreateDrawableObject(objectToDraw, DrawingCanvas, this);
                    actions.Add(a);
                    a.Do();
                }
            }
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            DrawingCanvas.Clear();
            PolynomialFunctionCanvas.Clear();
            GeometryObjects.Clear();

            foreach (IAction a in actions)
            {
                a.Do();
            }

            pbxCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GeometryObjects.Clear();

            IAction a = new ClearCanvas(this);
            actions.Add(a);
            a.Do();
        }

        private void pbxCanvas_Resize(object sender, EventArgs e)
        {
            DrawingCanvas.Height = PolynomialFunctionCanvas.Height = pbxCanvas.Height;
            DrawingCanvas.Width = PolynomialFunctionCanvas.Width = pbxCanvas.Width;

            btnRedraw.PerformClick();
        }

        private void pbxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dragging)
            {
                IDrawable objectToDraw = getDrawnObject(startPoint, e.Location);

                DrawingCanvas.PreviewOnDrag(objectToDraw);
            }
        }

        private void rdoToolboxLine_CheckedChanged(object sender, EventArgs e)
        {
            grpLineGeneratorAlgorithm.Enabled = rdoToolboxLine.Checked;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            actions.RemoveAt(actions.Count - 1);
            btnRedraw.PerformClick();
        }

        private void toolboxNGon_CheckedChanged(object sender, EventArgs e)
        {
            grpNGonOptions.Enabled = rdoToolboxRegularPolygon.Checked || rdoToolboxStar.Checked;
            txtNGonSkip.Enabled = lblNGonSkip.Enabled = rdoToolboxStar.Checked;
        }

        private void txtNGonEdges_Validating(object sender, CancelEventArgs e)
        {
            if (((Control)sender).Enabled)
            {
                int value, skip;

                try
                {
                    value = Convert.ToInt32(((TextBox)sender).Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Edge n-gon harus berisi angka.", "Validation error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    ((TextBox)sender).SelectAll();
                    return;
                }

                if (value < 3)
                {
                    MessageBox.Show("N-gon harus memiliki minimal tiga edge.", "Validation error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    ((TextBox)sender).SelectAll();
                    return;
                }

                CancelEventArgs skipCancel = new CancelEventArgs();
                txtNGonSkip_Validating(txtNGonSkip, skipCancel);
                if (skipCancel.Cancel == true)
                {
                    e.Cancel = true;
                    return;
                }

                skip = Convert.ToInt32(txtNGonSkip.Text);

                if (rdoToolboxStar.Checked && value < 2 * skip + 1)
                {
                    MessageBox.Show(String.Format("Edge n-gon minimal sama dengan 2 * skip + 1 = {0}.", 2 * skip + 1),
                        "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    ((TextBox)sender).SelectAll();
                    return;
                }
            }
        }

        private void txtNGonSkip_Validating(object sender, CancelEventArgs e)
        {
            if (((Control)sender).Enabled)
            {
                int skip;

                try
                {
                    skip = Convert.ToInt32(((Control)sender).Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Skip n-gon harus berisi angka.", "Validation error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    ((TextBox)sender).SelectAll();
                    return;
                }
            }
        }

        private void rdoToolboxPolynomialFunction_CheckedChanged(object sender, EventArgs e)
        {
            grpPolynomialFunction.Enabled = rdoToolboxPolynomialFunction.Checked;

            if (ActiveCanvas != null)
                ActiveCanvas.BitmapChanged -= CanvasChanged;

            if (rdoToolboxPolynomialFunction.Checked)
            {
                ActiveCanvas = PolynomialFunctionCanvas;
                ActiveCanvas.BitmapChanged += CanvasChanged;

                if (PolynomialFunctionCanvas.Objects.Count == 0)
                {
                    btnEditFunction.PerformClick();
                }
            }
            else
            {
                ActiveCanvas = DrawingCanvas;
                ActiveCanvas.BitmapChanged += CanvasChanged;
            }

            btnRedraw.PerformClick();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            PolynomialFunctionCanvas.Scale = (PolynomialFunctionCanvas.Scale << 1);
            btnZoomOut.Enabled = (PolynomialFunctionCanvas.Scale > 1);
        }

        private void btnEditFunction_Click(object sender, EventArgs e)
        {
            Form frm;
            if (PolynomialFunctionCanvas.Objects.Count > 0)
            {
                frm = new frmEditPolyFunc(PolynomialFunctionCanvas.Objects.Last().Constants);
            }
            else
            {
                frm = new frmEditPolyFunc();
            }
            frm.ShowDialog(this);
            frm.Dispose();
        }

        public void ChangePolynomialFunction(double[] constants)
        {
            PolynomialFunction f = new PolynomialFunction(constants, PolynomialFunctionCanvas, ObjectColor);
            IAction a = new CreatePolynomialFunctionObject(f, PolynomialFunctionCanvas);
            actions.Add(a);
            a.Do();
        }

        private void pbxObjectColor_Click(object sender, EventArgs e)
        {
            DialogResult dr = dlgColor.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ObjectColor = dlgColor.Color;
            }
        }

        private void pbxAxisColor_Click(object sender, EventArgs e)
        {
            DialogResult dr = dlgColor.ShowDialog();
            if (dr == DialogResult.OK)
            {
                AxisColor = dlgColor.Color;
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            PolynomialFunctionCanvas.Scale = (PolynomialFunctionCanvas.Scale >> 1);
            btnZoomOut.Enabled = (PolynomialFunctionCanvas.Scale > 1);
        }

        private IDrawable getDrawnObject(Point start, Point end)
        {
            if (rdoToolboxLine.Checked)
            {
                if (rdoLineBresenham.Checked)
                {
                    return new Line(start, new Point(end.X, end.Y), ObjectColor, new Bresenham());
                }
                else if (rdoLineDda.Checked)
                {
                    return new Line(start, new Point(end.X, end.Y), ObjectColor, new Dda());
                }
                else
                {
                    return new Line(start, new Point(end.X, end.Y), ObjectColor, new Naive());
                }
            }
            else if (rdoToolboxCircle.Checked)
            {
                int radius = (int)Math.Sqrt((end.X - start.X) * (end.X - start.X) +
                    (end.Y - start.Y) * (end.Y - start.Y));

                return new Circle(start, radius, ObjectColor);
            }
            else if (rdoToolboxEllipse.Checked)
            {
                int rx = Math.Abs(end.X - start.X);
                int ry = Math.Abs(end.Y - start.Y);

                return new Ellipse(start, rx, ry, ObjectColor);
            }
            else if (rdoToolboxRegularPolygon.Checked)
            {
                double circumradius = Math.Sqrt((end.X - start.X) * (end.X - start.X) +
                    (end.Y - start.Y) * (end.Y - start.Y));
                double angle = Math.Atan2(start.Y - end.Y, end.X - start.X);

                return new RegularPolygon(start, circumradius, Convert.ToInt32(txtNGonEdges.Text), angle, ObjectColor);
            }
            else if (rdoToolboxStar.Checked)
            {
                double circumradius = Math.Sqrt((end.X - start.X) * (end.X - start.X) +
                    (end.Y - start.Y) * (end.Y - start.Y));
                double angle = Math.Atan2(start.Y - end.Y, end.X - start.X);

                return new Star(start, circumradius, Convert.ToInt32(txtNGonEdges.Text),
                    Convert.ToInt32(txtNGonSkip.Text), angle, ObjectColor);
            }
            else if (rdoToolboxFloodFill.Checked)
            {
                return new FloodFill(end, ObjectColor, DrawingCanvas);
            }
            else
            {
                MessageBox.Show("Sesudah ini, pilih warna boundary.");
                DialogResult dr = dlgColor.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Color boundaryColor = dlgColor.Color;
                    return new BoundaryFill(end, ObjectColor, boundaryColor, DrawingCanvas);
                }
            }
            return null;
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            ITransformable o = (ITransformable)dgvObjectList.SelectedRows[0].DataBoundItem;
            int index = GeometryObjects.IndexOf((IDrawable)o);

            frmTransformationCreator f = new frmTransformationCreator();
            f.ShowDialog(this);

            if (f.TransformationMatrix != null)
            {
                IAction a = new ApplyTransformationMatrix(this, index, f.TransformationMatrix);
                actions.Add(a);
                a.Do();
                btnRedraw.PerformClick();
            }
        }
    }
}
