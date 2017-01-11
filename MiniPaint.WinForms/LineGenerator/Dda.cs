using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.LineGenerator
{
    class Dda : IDrawable
    {
        private DrawingObject.Line line;

        public Dda(DrawingObject.Line line)
        {
            this.line = line;
        }

        public void Draw(Graphics g, Color c)
        {
            Brush br = new SolidBrush(c);
            Size sz = new Size(1, 1);

            int dx = line.End.X - line.Start.X;
            int dy = line.End.Y - line.Start.Y;

            int step = Math.Max(Math.Abs(dx), Math.Abs(dy));
            double x_tambah = (double)dx / step;
            double y_tambah = (double)dy / step;

            double x = line.Start.X;
            double y = line.Start.Y;
            while (step >= 0)
            {
                g.FillRectangle(br, new Rectangle(new Point((int)x, (int)y), sz));
                x += x_tambah;
                y += y_tambah;
                step--;
            }
        }
    }
}
