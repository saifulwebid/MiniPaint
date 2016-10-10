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
        private Point startPoint;
        private bool dragging;

        public frmMain()
        {
            InitializeComponent();

            lines = new Stack<DrawingObject.Line>();
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
                lines.Push(new DrawingObject.Line(startPoint, new Point(e.X, e.Y)));
                dragging = false;
                pnlCanvas.Invalidate();
            }
        }

        private void allLineRadioBox_CheckedChanged(object sender, EventArgs e)
        {
            pnlCanvas.Invalidate();
        }
    }
}
