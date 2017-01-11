using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.Transformation
{
    static class ScalingMatrixFactory
    {
        public static Matrix CreateMatrix(double sc)
        {
            return new Matrix(sc, 0, 0, sc, 0, 0);
        }

        public static Matrix CreateMatrix(double sc, Point p)
        {
            Matrix m = TranslationMatrixFactory.CreateMatrix(-p.X, -p.Y);
            m.Apply(CreateMatrix(sc));
            m.Apply(TranslationMatrixFactory.CreateMatrix(p.X, p.Y));

            return m;
        }
    }
}
