using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.DrawingObject
{
    class Line
    {
        private Point start, end;

        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }

        public void DrawDDA(Graphics g)
        {
            int dx = end.X - start.X;
            int dy = end.Y - start.Y;

            int step = Math.Max(Math.Abs(dx), Math.Abs(dy));
            double x_tambah = (double)dx / step;
            double y_tambah = (double)dy / step;

            double x = start.X;
            double y = start.Y;
            while (step > 0)
            {
                g.FillRectangle(Brushes.Blue, new Rectangle(new Point((int)x, (int)y), new Size(1, 1)));
                x += x_tambah;
                y += y_tambah;
                step--;
            }
        }

        public void DrawNaive(Graphics g)
        {
            int dx = end.X - start.X;
            int dy = end.Y - start.Y;

            double m = (double)dy / dx;
            double c = start.Y - m * start.X;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                int x_start = Math.Min(start.X, end.X);
                int x_end = Math.Max(start.X, end.X);

                for (int x = x_start; x <= x_end; x++)
                {
                    int y = (int)(m * x + c);
                    g.FillRectangle(Brushes.Black, new Rectangle(new Point(x, y), new Size(1, 1)));
                }
            }
            else
            {
                int y_start = Math.Min(start.Y, end.Y);
                int y_end = Math.Max(start.Y, end.Y);

                for (int y = y_start; y <= y_end; y++)
                {
                    int x;
                    if (dx == 0)
                    {
                        x = start.X;
                    }
                    else
                    {
                        x = (int)((y - c) / m);
                    }

                    g.FillRectangle(Brushes.Black, new Rectangle(new Point(x, y), new Size(1, 1)));
                }
            }
        }
    }
}
