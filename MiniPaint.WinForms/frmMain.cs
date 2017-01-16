﻿using System;
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

namespace MiniPaint.WinForms
{
    public partial class frmMain : Form
    {
        private Stack<IDrawable> objects;
        private Stack<IDrawable> geoObjects, mathObjects;
        private Stack<IAction> actions;
        private Axis axis;
        private Point startPoint;
        private bool dragging;
        private Bitmap drawingBitmap, preClickBitmap;
        private int scale = (1 << 6);
        private Color objectColor;
        private Color axisColor;
        private Canvas.Canvas activeCanvas;
        private DrawingCanvas drawingCanvas;
        private PolynomialFunctionCanvas polynomialFunctionCanvas;

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
                return axisColor;
            }
            set
            {
                axisColor = value;
                pbxAxisColor.BackColor = value;

                axis.ForegroundColor = value;
                btnRedraw_Click(null, null);
            }
        }

        public frmMain()
        {
            InitializeComponent();

            geoObjects = new Stack<IDrawable>();
            mathObjects = new Stack<IDrawable>();
            actions = new Stack<IAction>();
            axis = new Axis(pbxCanvas.Height, pbxCanvas.Width, scale, AxisColor);
            dragging = false;

            /* Initialize canvas */
            drawingCanvas = new DrawingCanvas(pbxCanvas.Width, pbxCanvas.Height);
            polynomialFunctionCanvas = new PolynomialFunctionCanvas(pbxCanvas.Width, pbxCanvas.Height);
            activeCanvas = drawingCanvas;
            activeCanvas.BitmapChanged += new EventHandler(CanvasChanged);

            rdoToolboxLine_CheckedChanged(null, null);
            toolboxNGon_CheckedChanged(null, null);
            rdoToolboxPolynomialFunction_CheckedChanged(null, null);

            ObjectColor = Color.Black;
            AxisColor = Color.Gray;
        }

        private void CanvasChanged(object sender, EventArgs e)
        {
            pbxCanvas.Invalidate();
        }

        private void pbxCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingBitmap, 0, 0);
        }

        private void pbxCanvas_MouseDown(object sender, MouseEventArgs e)
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

        private void pbxCanvas_MouseUp(object sender, MouseEventArgs e)
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

        private void pbxCanvas_Resize(object sender, EventArgs e)
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
            foreach (PolynomialFunction obj in mathObjects)
            {
                obj.ResetAxisSize(o.Height, o.Width);
            }
            if (rdoToolboxPolynomialFunction.Checked)
            {
                btnRedraw_Click(sender, e);
            }
        }

        private void pbxCanvas_MouseMove(object sender, MouseEventArgs e)
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
            foreach (PolynomialFunction o in mathObjects)
                o.Scale = scale;
            btnZoomOut.Enabled = (scale > 1);
            btnRedraw_Click(sender, e);
        }

        private void btnEditFunction_Click(object sender, EventArgs e)
        {
            Form frm;
            if (mathObjects.Count > 0)
            {
                frm = new frmEditPolyFunc(((PolynomialFunction)(mathObjects.Peek())).Constants);
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
            mathObjects.Push(new PolynomialFunction(constants, pbxCanvas.Height, pbxCanvas.Width, scale, ObjectColor));
            btnRedraw_Click(null, null);
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
            scale = (scale >> 1);
            axis.Scale = scale;
            foreach (PolynomialFunction o in mathObjects)
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
            else // rdoToolboxStar.Checked
            {
                double circumradius = Math.Sqrt((end.X - start.X) * (end.X - start.X) +
                    (end.Y - start.Y) * (end.Y - start.Y));
                double angle = Math.Atan2(start.Y - end.Y, end.X - start.X);

                return new Star(start, circumradius, Convert.ToInt32(txtNGonEdges.Text),
                    Convert.ToInt32(txtNGonSkip.Text), angle, ObjectColor);
            }
        }
    }
}
