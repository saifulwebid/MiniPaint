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

        public void Draw(Graphics g, Color cr)
        {
            Brush br = new SolidBrush(cr);
            Size sz = new Size(1, 1);

            int dx = line.End.X - line.Start.X;
            int dy = line.End.Y - line.Start.Y;

            double m = (double)dy / dx;
            double c = line.Start.Y - m * line.Start.X;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                int x_start = Math.Min(line.Start.X, line.End.X);
                int x_end = Math.Max(line.Start.X, line.End.X);

                for (int x = x_start; x <= x_end; x++)
                {
                    int y = (int)(m * x + c);
                    g.FillRectangle(br, new Rectangle(new Point(x, y), sz));
                }
            }
            else
            {
                int y_start = Math.Min(line.Start.Y, line.End.Y);
                int y_end = Math.Max(line.Start.Y, line.End.Y);

                for (int y = y_start; y <= y_end; y++)
                {
                    int x;
                    if (dx == 0)
                    {
                        x = line.Start.X;
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
