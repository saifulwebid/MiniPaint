using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.DrawingObject;

namespace MiniPaint.WinForms.LineGenerator
{
    interface ILineGenerator
    {
        void Draw(Graphics g, Line l);
    }
}
