﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.LineGenerator;

namespace MiniPaint.WinForms.DrawingObject
{
    class Line : IDrawable
    {
        public Point Start { get; }
        public Point End { get; }
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
        public Color ForegroundColor { get; set; }
        public ILineGenerator LineGenerator { get; set; }

        public Line(Point start, Point end, ILineGenerator lg)
        {
            Start = start;
            End = end;
            LineGenerator = lg;
        }

        public void Draw(Graphics g)
        {
            LineGenerator.Draw(g, this);
        }
    }
}
