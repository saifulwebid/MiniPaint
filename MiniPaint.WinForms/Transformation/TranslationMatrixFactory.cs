using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.Transformation
{
    static class TranslationMatrixFactory
    {
        public static Matrix CreateMatrix(int dx, int dy)
        {
            return new Matrix(1, 0, 0, 1, dx, dy);
        }
    }
}
