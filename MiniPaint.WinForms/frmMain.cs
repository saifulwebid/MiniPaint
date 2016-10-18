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
        private Stack<DrawingObject.Line> lines;
        private Stack<DrawingObject.Circle> circles;
        private Stack<DrawingObject.Ellipse> ellipses;
        private Point startPoint;
        private bool dragging;

        public frmMain()
        {
            InitializeComponent();

            lines = new Stack<DrawingObject.Line>();
            circles = new Stack<DrawingObject.Circle>();
            ellipses = new Stack<DrawingObject.Ellipse>();
            dragging = false;
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (DrawingObject.Line l in lines)
            {
                if (rdoLineNaive.Checked)
                    l.DrawNaive(e.Graphics);

                if (rdoLineDda.Checked)
                    l.DrawDDA(e.Graphics);

                if (rdoLineBresenham.Checked)
                    l.DrawBresenham(e.Graphics);
            }

            foreach (DrawingObject.Circle c in circles)
            {
                c.Draw(e.Graphics);
            }

            foreach (DrawingObject.Ellipse el in ellipses)
            {
                el.Draw(e.Graphics);
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
                    lines.Push(new DrawingObject.Line(startPoint, new Point(e.X, e.Y)));
                }
                else if (rdoToolboxCircle.Checked)
                {
                    int radius = (int)Math.Sqrt((e.X - startPoint.X) * (e.X - startPoint.X) +
                        (e.Y - startPoint.Y) * (e.Y - startPoint.Y));

                    circles.Push(new DrawingObject.Circle(startPoint, radius));
                }
                else if (rdoToolboxEllipse.Checked)
                {
                    int rx = (int)(Math.Abs(e.X - startPoint.X) * 0.5);
                    int ry = (int)(Math.Abs(e.Y - startPoint.Y) * 0.5);

                    ellipses.Push(new DrawingObject.Ellipse(new Point(Math.Min(e.X, startPoint.X) + rx, Math.Min(e.Y, startPoint.Y) + ry), rx, ry));
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
            lines.Clear();
            circles.Clear();
            pnlCanvas.Invalidate();
        }

        private void rdoToolboxLine_CheckedChanged(object sender, EventArgs e)
        {
            grpLineGeneratorAlgorithm.Enabled = rdoToolboxLine.Checked;
        }
    }
}
