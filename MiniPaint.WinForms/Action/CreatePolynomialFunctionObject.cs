using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.Canvas;
using MiniPaint.WinForms.DrawingObject;

namespace MiniPaint.WinForms.Action
{
    class CreatePolynomialFunctionObject : IAction
    {
        private PolynomialFunction drawableObject;
        private PolynomialFunctionCanvas canvas;

        public CreatePolynomialFunctionObject(PolynomialFunction o, PolynomialFunctionCanvas c)
        {
            drawableObject = o;
            canvas = c;
        }
        public void Do()
        {
            canvas.Objects.Add(drawableObject);
        }
    }
}
