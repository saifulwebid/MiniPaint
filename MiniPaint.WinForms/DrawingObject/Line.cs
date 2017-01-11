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
        public Point start
        {
            get;
        }

        public Point end
        {
            get;
        }

        public double M
        {
            get
            {
                return (end.Y - start.Y) / (end.X - start.X);
            }
        }

        public double C
        {
            get
            {
                if (double.IsInfinity(M))
                {
                    return -end.X;
                }
                else
                {
                    return end.Y - M * end.X;
                }
            }
        }

        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
