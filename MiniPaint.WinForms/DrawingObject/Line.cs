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

        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
