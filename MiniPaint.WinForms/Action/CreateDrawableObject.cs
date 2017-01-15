using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.WinForms.Action
{
    class CreateDrawableObject : IAction
    {
        private IDrawable drawableObject;
        private Graphics graphics;

        public CreateDrawableObject(IDrawable o, Graphics g)
        {
            drawableObject = o;
            graphics = g;
        }

        public void Do()
        {
            drawableObject.Draw(graphics);
        }
    }
}
