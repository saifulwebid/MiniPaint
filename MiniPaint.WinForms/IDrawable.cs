using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.WinForms
{
    interface IDrawable
    {
        Color ForegroundColor { get; set; }

        void Draw(Graphics g);
    }
}
