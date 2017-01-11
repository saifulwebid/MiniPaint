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
        public Point Start
        {
            get;
        }

        public Point End
        {
            get;
        }

        public double M
        {
            get
            {
                return (End.Y - Start.Y) / (End.X - Start.X);
            }
        }

        public double C
        {
            get
            {
                if (double.IsInfinity(M))
                {
                    return -End.X;
                }
                else
                {
                    return End.Y - M * End.X;
                }
            }
        }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }
}
