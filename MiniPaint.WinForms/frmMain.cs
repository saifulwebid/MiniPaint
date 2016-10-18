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
        private Point startPoint;
        private bool dragging;

        public frmMain()
        {
            InitializeComponent();

            objects = new Stack<IDrawable>();
            dragging = false;
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (IDrawable o in objects)
            {
                o.Draw(e.Graphics);
            }
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                if (rdoToolboxLine.Checked)
                {
                    if (rdoLineBresenham.Checked)
                    {
                        objects.Push(new LineGenerator.Bresenham(new DrawingObject.Line(startPoint, new Point(e.X, e.Y))));
                    }
                    else if (rdoLineDda.Checked)
                    {
                        objects.Push(new LineGenerator.Dda(new DrawingObject.Line(startPoint, new Point(e.X, e.Y))));
                    }
                    else if (rdoLineNaive.Checked)
                    {
                        objects.Push(new LineGenerator.Naive(new DrawingObject.Line(startPoint, new Point(e.X, e.Y))));
                    }
                }
                else if (rdoToolboxCircle.Checked)
                {
                    int radius = (int)Math.Sqrt((e.X - startPoint.X) * (e.X - startPoint.X) +
                        (e.Y - startPoint.Y) * (e.Y - startPoint.Y));

                    objects.Push(new DrawingObject.Circle(startPoint, radius));
                }
                else if (rdoToolboxEllipse.Checked)
                {
                    int rx = (int)(Math.Abs(e.X - startPoint.X) * 0.5);
                    int ry = (int)(Math.Abs(e.Y - startPoint.Y) * 0.5);

                    objects.Push(new DrawingObject.Ellipse(new Point(Math.Min(e.X, startPoint.X) + rx, Math.Min(e.Y, startPoint.Y) + ry), rx, ry));
                }

                dragging = false;
                pnlCanvas.Invalidate();
            }
        }

        private void allLineRadioBox_CheckedChanged(object sender, EventArgs e)
        {
            pnlCanvas.Invalidate();
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            pnlCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            objects.Clear();
            pnlCanvas.Invalidate();
        }

        private void rdoToolboxLine_CheckedChanged(object sender, EventArgs e)
        {
            grpLineGeneratorAlgorithm.Enabled = rdoToolboxLine.Checked;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            objects.Pop();
            pnlCanvas.Invalidate();
        }
    }
}
