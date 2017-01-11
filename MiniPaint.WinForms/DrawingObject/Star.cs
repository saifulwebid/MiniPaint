using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.LineGenerator;

namespace MiniPaint.WinForms.DrawingObject
{
    class Star : IDrawable
    {
        private Point center;
        private double circumradius;
        private int n;
        private int skip;
        private double firstVertexAngle;

        public Color ForegroundColor { get; set; }

        public Star(Point center, double circumradius, int n, int skip, double firstVertexAngle, Color c)
        {
            this.center = center;
            this.circumradius = circumradius;
            this.n = n;
            this.skip = skip;
            this.firstVertexAngle = firstVertexAngle;
            ForegroundColor = c;
        }

        public void Draw(Graphics g)
        {
            int sx, sy, ex, ey;
            double r = Math.Cos(skip * Math.PI / n) / Math.Cos((skip - 1) * Math.PI / n);

            for (int i = 0; i < 2 * n; i++)
            {
                sx = center.X + (int)(circumradius * (i % 2 == 1 ? r : 1) * Math.Cos(firstVertexAngle + Math.PI * i / n));
                sy = center.Y - (int)(circumradius * (i % 2 == 1 ? r : 1) * Math.Sin(firstVertexAngle + Math.PI * i / n));
                ex = center.X + (int)(circumradius * ((i + 1) % 2 == 1 ? r : 1) * Math.Cos(firstVertexAngle + Math.PI * (i + 1) / n));
                ey = center.Y - (int)(circumradius * ((i + 1) % 2 == 1 ? r : 1) * Math.Sin(firstVertexAngle + Math.PI * (i + 1) / n));

                new Line(new Point(sx, sy), new Point(ex, ey), ForegroundColor, new Bresenham()).Draw(g);
            }
        }
    }
}
