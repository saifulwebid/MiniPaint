using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.Canvas
{
    class DrawingCanvas : Canvas
    {
        private Bitmap preDragBitmap;

        public DrawingCanvas(int height, int width) : base(height, width)
        {
            preDragBitmap = null;
        }

        public void PrepareForDragging()
        {
            preDragBitmap = (Bitmap)Bitmap.Clone();
        }

        public void PreviewOnDrag(IDrawable o)
        {
            Bitmap.Dispose();
            Bitmap = (Bitmap)preDragBitmap.Clone();
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                o.Draw(g);
            }

            OnBitmapChanged();
        }

        public void FinishDragging()
        {
            Bitmap.Dispose();
            Bitmap = (Bitmap)preDragBitmap.Clone();
            preDragBitmap.Dispose();
            preDragBitmap = null;
        }
        }
    }
}
