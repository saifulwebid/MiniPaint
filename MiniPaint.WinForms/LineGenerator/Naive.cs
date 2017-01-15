using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.DrawingObject;

namespace MiniPaint.WinForms.LineGenerator
{
    class Naive : ILineGenerator
    {
        public void Draw(Graphics g, Line l)
        {
            Brush br = new SolidBrush(l.ForegroundColor);
            Size sz = new Size(1, 1);

            int dx = l.End.X - l.Start.X;
            int dy = l.End.Y - l.Start.Y;

            double m = (double)dy / dx;
            double c = l.Start.Y - m * l.Start.X;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                int x_start = Math.Min(l.Start.X, l.End.X);
                int x_end = Math.Max(l.Start.X, l.End.X);

                for (int x = x_start; x <= x_end; x++)
                {
                    int y = (int)(m * x + c);
                    g.FillRectangle(br, new Rectangle(l.TransformationMatrix.Transform(new Point(x, y)), sz));
                }
            }
            else
            {
                int y_start = Math.Min(l.Start.Y, l.End.Y);
                int y_end = Math.Max(l.Start.Y, l.End.Y);

                for (int y = y_start; y <= y_end; y++)
                {
                    int x;
                    if (dx == 0)
                    {
                        x = l.Start.X;
                    }
                    else
                    {
                        x = (int)((y - c) / m);
                    }

                    g.FillRectangle(br, new Rectangle(l.TransformationMatrix.Transform(new Point(x, y)), sz));
                }
            }
        }
    }
}
