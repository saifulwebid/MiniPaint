using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.DrawingObject;

namespace MiniPaint.WinForms.LineGenerator
{
    class Bresenham : ILineGenerator
    {
        /// Implementation taken from
        /// https://rosettacode.org/wiki/Bitmap/Bresenham%27s_line_algorithm#C
        public void Draw(Graphics g, Line l)
        {
            Brush br = new SolidBrush(l.ForegroundColor);
            Size sz = new Size(1, 1);

            int dx = Math.Abs(l.End.X - l.Start.X);
            int sx = l.Start.X < l.End.X ? 1 : -1;

            int dy = Math.Abs(l.End.Y - l.Start.Y);
            int sy = l.Start.Y < l.End.Y ? 1 : -1;

            int err = (dx > dy ? dx : -dy) / 2;
            int e2;

            int x = l.Start.X;
            int y = l.Start.Y;
            while (true)
            {
                g.FillRectangle(br, new Rectangle(l.TransformationMatrix.Transform(new Point(x, y)), sz));

                if (x == l.End.X && y == l.End.Y)
                    break;

                e2 = err;
                if (e2 > -dx)
                {
                    err -= dy;
                    x += sx;
                }
                if (e2 < dy)
                {
                    err += dx;
                    y += sy;
                }
            }
        }
    }
}
