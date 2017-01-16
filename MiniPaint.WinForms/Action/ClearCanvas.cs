using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.Action
{
    class ClearCanvas : IAction
    {
        private frmMain form;

        public ClearCanvas(frmMain f)
        {
            form = f;
        }

        public void Do()
        {
            form.DrawingCanvas.Clear();
        }
    }
}
