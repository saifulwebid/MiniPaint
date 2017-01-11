using System;
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
    }
}
