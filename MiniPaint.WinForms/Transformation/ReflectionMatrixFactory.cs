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
                return new Matrix((-(l.M * l.M) + 1) / (l.M * l.M + 1),
                    2 * l.M / (l.M * l.M + 1),
                    2 * l.M / (l.M * l.M + 1),
                    (l.M * l.M - 1) / (l.M * l.M + 1),
                    2 * l.M * l.C / (l.M * l.M + 1),
                    (-l.C * (l.M * l.M - 1)) / (l.M * l.M + 1));
            }
        }
    }
}
