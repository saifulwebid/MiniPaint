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
            double x_tambah = (double)dx / (double)step;
            double y_tambah = (double)dy / (double)step;

            double x = (double)start.X;
            double y = (double)start.Y;
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

            double m = (double)dy / (double)dx;
            
            double c = start.Y - m * start.X;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                if (start.X < end.X)
                {
                    for (int x = start.X; x <= end.X; x++)
                    {
                        int y = (int)(m * x + c);
                        g.FillRectangle(Brushes.Black, new Rectangle(new Point(x, y), new Size(1, 1)));
                    }
                }
                else
                {
                    for (int x = end.X; x <= start.X; x++)
                    {
                        int y = (int)(m * x + c);
                        g.FillRectangle(Brushes.Black, new Rectangle(new Point(x, y), new Size(1, 1)));
                    }
                }
            }
            else
            {
                if (start.Y < end.Y)
                {
                    for (int y = start.Y; y <= end.Y; y++)
                    {
                        int x = (int)((y - c) / m);
                        g.FillRectangle(Brushes.Black, new Rectangle(new Point(x, y), new Size(1, 1)));
                    }
                }
                else
                {
                    for (int y = end.Y; y <= start.Y; y++)
                    {
                        int x = (int)((y - c) / m);
                        g.FillRectangle(Brushes.Black, new Rectangle(new Point(x, y), new Size(1, 1)));
                    }
                }
            }
        }
    }
}
