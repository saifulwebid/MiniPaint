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
        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.Red);
            Size sz = new Size(1, 1);

            int dx = Math.Abs(line.end.X - line.start.X);
            int sx = line.start.X < line.end.X ? 1 : -1;

            int dy = Math.Abs(line.end.Y - line.start.Y);
            int sy = line.start.Y < line.end.Y ? 1 : -1;

            int err = (dx > dy ? dx : -dy) / 2;
            int e2;

            int x = line.start.X;
            int y = line.start.Y;
            while (true)
            {
                g.FillRectangle(br, new Rectangle(new Point(x, y), sz));

                if (x == line.end.X && y == line.end.Y)
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
