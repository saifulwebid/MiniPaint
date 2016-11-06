using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint.WinForms
{
    public partial class frmMain : Form
    {
        private Stack<IDrawable> objects;
        private Stack<IDrawable> geoObjects, mathObjects;
        private DrawingObject.Axis axis;
        private Point startPoint;
        private bool dragging;
        private Bitmap drawingBitmap, preClickBitmap;
        private int scale = (1 << 6);

        public frmMain()
        {
            InitializeComponent();

            geoObjects = new Stack<IDrawable>();
            mathObjects = new Stack<IDrawable>();
            axis = new DrawingObject.Axis(pbxCanvas.Height, pbxCanvas.Width, scale);
            dragging = false;

            rdoToolboxLine_CheckedChanged(null, null);
            toolboxNGon_CheckedChanged(null, null);
            rdoToolboxPolynomialFunction_CheckedChanged(null, null);
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingBitmap, 0, 0);
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (!rdoToolboxPolynomialFunction.Checked)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
                preClickBitmap = (Bitmap)drawingBitmap.Clone();

                CancelEventArgs c = new CancelEventArgs();
                txtNGonEdges_Validating(txtNGonEdges, c);
                if (c.Cancel == false)
                {
                    txtNGonSkip_Validating(txtNGonEdges, c);
                }
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                IDrawable objectToDraw = getDrawnObject(startPoint, e.Location);
                geoObjects.Push(objectToDraw);

                drawingBitmap.Dispose();
                drawingBitmap = (Bitmap)preClickBitmap.Clone();
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    objectToDraw.Draw(g);
                }

                dragging = false;
                preClickBitmap.Dispose();
                ((Control)sender).Invalidate();
            }
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            if (drawingBitmap != null)
                drawingBitmap.Dispose();

            drawingBitmap = new Bitmap(pbxCanvas.Width, pbxCanvas.Height);

            using (Graphics g = Graphics.FromImage(drawingBitmap))
            {
                if (rdoToolboxPolynomialFunction.Checked)
                {
                    axis.Draw(g);
                }

                foreach (IDrawable o in objects)
                {
                    o.Draw(g);
                }
            }

            pbxCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            objects.Clear();
            btnRedraw_Click(sender, e);
        }

        private void pnlCanvas_Resize(object sender, EventArgs e)
        {
            Control o = (Control)sender;
            Bitmap newBitmap = new Bitmap(o.Width, o.Height);

            if (drawingBitmap != null)
            {
                using (Graphics g = Graphics.FromImage(newBitmap))
                {
                    g.DrawImage(drawingBitmap, 0, 0);
                }
                drawingBitmap.Dispose();
            }
            drawingBitmap = newBitmap;

            axis.ResetAxisSize(o.Height, o.Width);
            foreach (DrawingObject.PolynomialFunction obj in mathObjects)
            {
                obj.ResetAxisSize(o.Height, o.Width);
            }
            if (rdoToolboxPolynomialFunction.Checked)
            {
                btnRedraw_Click(sender, e);
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dragging)
            {
                IDrawable objectToDraw = getDrawnObject(startPoint, e.Location);

                drawingBitmap.Dispose();
                drawingBitmap = (Bitmap)preClickBitmap.Clone();
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    objectToDraw.Draw(g);
                }

                ((Control)sender).Invalidate();
            }
        }

        private void rdoToolboxLine_CheckedChanged(object sender, EventArgs e)
        {
            grpLineGeneratorAlgorithm.Enabled = rdoToolboxLine.Checked;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (objects.Count > 0)
            {
                objects.Pop();
                btnRedraw_Click(sender, e);
            }
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
            if (rdoToolboxPolynomialFunction.Checked)
            {
                objects = mathObjects;
                if (mathObjects.Count == 0)
                {
                    btnEditFunction_Click(sender, e);
                }
            }
            else
            {
                objects = geoObjects;
            }
            btnRedraw_Click(sender, e);
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            scale = (scale << 1);
            axis.Scale = scale;
            foreach (DrawingObject.PolynomialFunction o in mathObjects)
                o.Scale = scale;
            btnZoomOut.Enabled = (scale > 1);
            btnRedraw_Click(sender, e);
        }

        private void btnEditFunction_Click(object sender, EventArgs e)
        {
            Form frm;
            if (mathObjects.Count > 0)
            {
                frm = new frmEditPolyFunc(((DrawingObject.PolynomialFunction)(mathObjects.Peek())).Constants);
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
            mathObjects.Clear();
            mathObjects.Push(new DrawingObject.PolynomialFunction(constants, pbxCanvas.Height, pbxCanvas.Width, scale));
            btnRedraw_Click(null, null);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            scale = (scale >> 1);
            axis.Scale = scale;
            foreach (DrawingObject.PolynomialFunction o in mathObjects)
                o.Scale = scale;
            btnZoomOut.Enabled = (scale > 1);
            btnRedraw_Click(sender, e);
        }

        private IDrawable getDrawnObject(Point start, Point end)
        {
            if (rdoToolboxLine.Checked)
            {
                if (rdoLineBresenham.Checked)
                {
                    return new LineGenerator.Bresenham(new DrawingObject.Line(start, new Point(end.X, end.Y)));
                }
                else if (rdoLineDda.Checked)
                {
                    return new LineGenerator.Dda(new DrawingObject.Line(start, new Point(end.X, end.Y)));
                }
                else
                {
                    return new LineGenerator.Naive(new DrawingObject.Line(start, new Point(end.X, end.Y)));
                }
            }
            else if (rdoToolboxCircle.Checked)
            {
                int radius = (int)Math.Sqrt((end.X - start.X) * (end.X - start.X) +
                    (end.Y - start.Y) * (end.Y - start.Y));

                return new DrawingObject.Circle(start, radius);
            }
            else if (rdoToolboxEllipse.Checked)
            {
                int rx = Math.Abs(end.X - start.X);
                int ry = Math.Abs(end.Y - start.Y);

                return new DrawingObject.Ellipse(start, rx, ry);
            }
            else if (rdoToolboxRegularPolygon.Checked)
            {
                double circumradius = Math.Sqrt((end.X - start.X) * (end.X - start.X) +
                    (end.Y - start.Y) * (end.Y - start.Y));
                double angle = Math.Atan2(start.Y - end.Y, end.X - start.X);

                return new DrawingObject.RegularPolygon(start, circumradius, Convert.ToInt32(txtNGonEdges.Text), angle);
            }
            else // rdoToolboxStar.Checked
            {
                double circumradius = Math.Sqrt((end.X - start.X) * (end.X - start.X) +
                    (end.Y - start.Y) * (end.Y - start.Y));
                double angle = Math.Atan2(start.Y - end.Y, end.X - start.X);

                return new DrawingObject.Star(start, circumradius, Convert.ToInt32(txtNGonEdges.Text),
                    Convert.ToInt32(txtNGonSkip.Text), angle);
            }
        }
    }
}
