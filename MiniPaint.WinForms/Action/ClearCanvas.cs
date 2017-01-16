using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.Action
{
    class ClearCanvas : IAction
    {
        private Canvas.Canvas canvas;

        public ClearCanvas(Canvas.Canvas c)
        {
            canvas = c;
        }

        public void Do()
        {
            canvas.Clear();
        }
    }
}
