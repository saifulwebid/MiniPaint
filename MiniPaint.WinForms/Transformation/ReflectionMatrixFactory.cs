using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.DrawingObject;

namespace MiniPaint.WinForms.Transformation
{
    static class ReflectionMatrixFactory
    {
        public static Matrix CreateMatrix(Line l)
        {
            if (double.IsInfinity(l.M))
            {
                int dx = (int)-l.C;

                Matrix m = TranslationMatrixFactory.CreateMatrix(-dx, 0);
                m.Apply(new Matrix(-1, 0, 0, 1, 0, 0));
                m.Apply(TranslationMatrixFactory.CreateMatrix(dx, 0));

                return m;
            }
            else
            {
                double m = l.M;
                double c = l.C;

                return new Matrix((-(m * m) + 1) / (m * m + 1),
                    2 * m / (m * m + 1),
                    2 * m / (m * m + 1),
                    (m * m - 1) / (m * m + 1),
                    2 * m * c / (m * m + 1),
                    (-c * (m * m - 1)) / (m * m + 1));
            }
        }
    }
}
