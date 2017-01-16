using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.LineGenerator;
using MiniPaint.WinForms.Transformation;

namespace MiniPaint.WinForms.DrawingObject
{
    class RegularPolygon : IDrawable, ITransformable
    {
        private Point center;
        private double circumradius;
        private int n;
        private double firstVertexAngle;

        public Color ForegroundColor { get; set; }
        public Matrix TransformationMatrix { get; set; }

        public RegularPolygon(Point center, double circumradius, int n, double firstVertexAngle, Color c)
        {
            this.center = center;
            this.circumradius = circumradius;
            this.n = n;
            this.firstVertexAngle = firstVertexAngle;
            ForegroundColor = c;
            TransformationMatrix = Matrix.Identity;
        }

        public void Draw(Graphics g)
        {
            int sx, sy, ex, ey;

            for (int i = 0; i < n; i++)
            {
                sx = center.X + (int)(circumradius * Math.Cos(firstVertexAngle + i * 2 * Math.PI / n));
                sy = center.Y - (int)(circumradius * Math.Sin(firstVertexAngle + i * 2 * Math.PI / n));
                ex = center.X + (int)(circumradius * Math.Cos(firstVertexAngle + (i + 1) * 2 * Math.PI / n));
                ey = center.Y - (int)(circumradius * Math.Sin(firstVertexAngle + (i + 1) * 2 * Math.PI / n));

                Line l = new Line(new Point(sx, sy), new Point(ex, ey), ForegroundColor, new Bresenham());
                l.TransformationMatrix.Apply(TransformationMatrix);
                l.Draw(g);
            }
        }
    }
}
