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

        public void Draw(Graphics g)
        {
            int dx = line.end.X - line.start.X;
            int dy = line.end.Y - line.start.Y;

            int step = Math.Max(Math.Abs(dx), Math.Abs(dy));
            double x_tambah = (double)dx / step;
            double y_tambah = (double)dy / step;

            double x = line.start.X;
            double y = line.start.Y;
            while (step > 0)
            {
                g.FillRectangle(Brushes.Blue, new Rectangle(new Point((int)x, (int)y), new Size(1, 1)));
                x += x_tambah;
                y += y_tambah;
                step--;
            }
        }
    }
}
