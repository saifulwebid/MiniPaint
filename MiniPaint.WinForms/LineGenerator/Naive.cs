using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.LineGenerator
{
    class Naive : IDrawable
    {
        private DrawingObject.Line line;

        public Naive(DrawingObject.Line line)
        {
            this.line = line;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.Black);
            Size sz = new Size(1, 1);

            int dx = line.end.X - line.start.X;
            int dy = line.end.Y - line.start.Y;

            double m = (double)dy / dx;
            double c = line.start.Y - m * line.start.X;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                int x_start = Math.Min(line.start.X, line.end.X);
                int x_end = Math.Max(line.start.X, line.end.X);

                for (int x = x_start; x <= x_end; x++)
                {
                    int y = (int)(m * x + c);
                    g.FillRectangle(br, new Rectangle(new Point(x, y), sz));
                }
            }
            else
            {
                int y_start = Math.Min(line.start.Y, line.end.Y);
                int y_end = Math.Max(line.start.Y, line.end.Y);

                for (int y = y_start; y <= y_end; y++)
                {
                    int x;
                    if (dx == 0)
                    {
                        x = line.start.X;
                    }
                    else
                    {
                        x = (int)((y - c) / m);
                    }

                    g.FillRectangle(br, new Rectangle(new Point(x, y), sz));
                }
            }
        }
    }
}
