using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.DrawingObject;

namespace MiniPaint.WinForms.LineGenerator
{
    class Dda : ILineGenerator
    {
        public void Draw(Graphics g, Line l)
        {
            Brush br = new SolidBrush(l.ForegroundColor);
            Size sz = new Size(1, 1);

            int dx = l.End.X - l.Start.X;
            int dy = l.End.Y - l.Start.Y;

            int step = Math.Max(Math.Abs(dx), Math.Abs(dy));
            double x_tambah = (double)dx / step;
            double y_tambah = (double)dy / step;

            double x = l.Start.X;
            double y = l.Start.Y;
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
