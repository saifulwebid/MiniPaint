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
        public frmMain()
        {
            InitializeComponent();
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            DrawingObject.Line l;

            l = new DrawingObject.Line(new Point(10, 10), new Point(100, 200));
            l.DrawDDA(e.Graphics);
            l.DrawNaive(e.Graphics);

            l = new DrawingObject.Line(new Point(30, 10), new Point(100, 100));
            l.DrawDDA(e.Graphics);
            l.DrawNaive(e.Graphics);

            l = new DrawingObject.Line(new Point(20, 100), new Point(21, 101));
            l.DrawDDA(e.Graphics);
            l.DrawNaive(e.Graphics);

            l = new DrawingObject.Line(new Point(10, 100), new Point(20, 10));
            l.DrawDDA(e.Graphics);
            l.DrawNaive(e.Graphics);
        }
    }
}
