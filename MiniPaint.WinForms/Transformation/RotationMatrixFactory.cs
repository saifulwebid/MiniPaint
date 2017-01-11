using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.Transformation
{
    static class RotationMatrixFactory
    {
        public static Matrix CreateMatrix(Double d)
        {
            return new Matrix(Math.Cos(d), -Math.Sin(d), Math.Sin(d), Math.Cos(d), 0, 0);
        }
    }
}
