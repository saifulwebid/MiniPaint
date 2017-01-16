using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.Canvas;

namespace MiniPaint.WinForms.Action
{
    class CreateDrawableObject : IAction
    {
        private IDrawable drawableObject;
        private DrawingCanvas canvas;

        public CreateDrawableObject(IDrawable o, DrawingCanvas c)
        {
            drawableObject = o;
            canvas = c;
        }

        public void Do()
        {
            canvas.Draw(drawableObject);
        }
    }
}
