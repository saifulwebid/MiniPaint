using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.WinForms.Transformation
{
    class Matrix
    {
        public double M11;
        public double M12;
        public double M21;
        public double M22;
        public double OffsetX;
        public double OffsetY;

        public Matrix(double M11, double M12, double M21, double M22, double OffsetX, double OffsetY)
        {
            this.M11 = M11;
            this.M12 = M12;
            this.M21 = M21;
            this.M22 = M22;
            this.OffsetX = OffsetX;
            this.OffsetY = OffsetY;
        }

        public static Matrix Identity
        {
            get
            {
                return new Matrix(1, 0, 0, 1, 0, 0);
            }
        }

        public void Apply(Matrix m)
        {
            double m11 = M11 * m.M11 + M12 * m.M21;
            double m12 = M11 * m.M12 + M12 * m.M22;
            double m21 = M21 * m.M11 + M22 * m.M21;
            double m22 = M21 * m.M12 + M22 * m.M22;
            double offsetX = M11 * m.OffsetX + M12 * m.OffsetY + OffsetX;
            double offsetY = M21 * m.OffsetX + M22 * m.OffsetY + OffsetY;

            M11 = m11;
            M12 = m12;
            M21 = m21;
            M22 = m22;
            OffsetX = offsetX;
            OffsetY = offsetY;
        }

        public Point Transform(Point p)
        {
            Point newPoint = new Point();

            newPoint.X = (int)(M11 * p.X + M12 * p.Y + OffsetX);
            newPoint.Y = (int)(M21 * p.X + M22 * p.Y + OffsetY);

            return newPoint;
        }
    }
}
