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
        private frmMain form;

        public CreateDrawableObject(IDrawable o, DrawingCanvas c, frmMain f)
        {
            drawableObject = o;
            canvas = c;
            form = f;
        }

        public void Do()
        {
            canvas.Draw(drawableObject);
            form.GeometryObjects.Add(drawableObject);
        }
    }
}
