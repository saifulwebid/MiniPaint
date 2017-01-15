using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.Canvas
{
    class PolynomialFunctionCanvas : ICanvas
    {
        private int height;
        private int width;

        public Bitmap Bitmap { get; set; }
        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                Resize();
            }
        }
        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                Resize();
            }
        }

        public PolynomialFunctionCanvas(int height, int width)
        {
            Bitmap = new Bitmap(height, width);
            this.height = height;
            this.width = width;
        }

        private void Resize()
        {
            Bitmap newBitmap = new Bitmap(Height, Width);

            if (Bitmap != null)
            {
                using (Graphics g = Graphics.FromImage(newBitmap))
                {
                    g.DrawImage(Bitmap, 0, 0);
                }
                Bitmap.Dispose();
            }
            Bitmap = newBitmap;
        }
    }
}
