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
        private Point startPoint;
        private bool dragging;

        public frmMain()
        {
            InitializeComponent();

            lines = new Stack<DrawingObject.Line>();
            circles = new Stack<DrawingObject.Circle>();
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
                    lines.Push(new DrawingObject.Line(startPoint, new Point(e.X, e.Y)));

                if (rdoToolboxCircle.Checked)
                {
                    int radius = (int)Math.Sqrt((e.X - startPoint.X) * (e.X - startPoint.X) +
                        (e.Y - startPoint.Y) * (e.Y - startPoint.Y));

                    circles.Push(new DrawingObject.Circle(startPoint, radius));
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
    }
}
