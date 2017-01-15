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

        public CreateDrawableObject(IDrawable o)
        {
            drawableObject = o;
        }

        public void Do(Graphics g)
        {
            drawableObject.Draw(g);
        }
    }
}
