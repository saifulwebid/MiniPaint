using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.DrawingObject
{
    class RegularPolygon : IDrawable
    {
        private Point center;
        private double circumradius;
        private int n;
        private double firstVertexAngle;

        public RegularPolygon(Point center, double circumradius, int n, double firstVertexAngle)
        {
            this.center = center;
            this.circumradius = circumradius;
            this.n = n;
            this.firstVertexAngle = firstVertexAngle;
        }

        public void Draw(Graphics g, Color c)
        {
            int sx, sy, ex, ey;

            for (int i = 0; i < n; i++)
            {
                sx = center.X + (int)(circumradius * Math.Cos(firstVertexAngle + i * 2 * Math.PI / n));
                sy = center.Y - (int)(circumradius * Math.Sin(firstVertexAngle + i * 2 * Math.PI / n));
                ex = center.X + (int)(circumradius * Math.Cos(firstVertexAngle + (i + 1) * 2 * Math.PI / n));
                ey = center.Y - (int)(circumradius * Math.Sin(firstVertexAngle + (i + 1) * 2 * Math.PI / n));

                new LineGenerator.Bresenham(new Line(new Point(sx, sy), new Point(ex, ey))).Draw(g, c);
            }
        }
    }
}
