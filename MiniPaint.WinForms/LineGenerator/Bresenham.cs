using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.LineGenerator
{
    class Bresenham : IDrawable
    {
        private DrawingObject.Line line;

        public Bresenham(DrawingObject.Line line)
        {
            this.line = line;
        }

        /// <summary>
        /// https://rosettacode.org/wiki/Bitmap/Bresenham%27s_line_algorithm#C
        /// </summary>
        public void Draw(Graphics g, Color c)
        {
            Brush br = new SolidBrush(c);
            Size sz = new Size(1, 1);

            int dx = Math.Abs(line.End.X - line.Start.X);
            int sx = line.Start.X < line.End.X ? 1 : -1;

            int dy = Math.Abs(line.End.Y - line.Start.Y);
            int sy = line.Start.Y < line.End.Y ? 1 : -1;

            int err = (dx > dy ? dx : -dy) / 2;
            int e2;

            int x = line.Start.X;
            int y = line.Start.Y;
            while (true)
            {
                g.FillRectangle(br, new Rectangle(new Point(x, y), sz));

                if (x == line.End.X && y == line.End.Y)
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
