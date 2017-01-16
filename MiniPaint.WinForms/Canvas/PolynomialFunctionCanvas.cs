using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.Canvas
{
    class PolynomialFunctionCanvas : Canvas
    {
        public PolynomialFunctionCanvas(int width, int height) : base(width, height)
        {
        }

        public override void Clear()
        {
            Bitmap.Dispose();
            Bitmap = new Bitmap(Width, Height);

            OnBitmapChanged();
        }
    }
}
