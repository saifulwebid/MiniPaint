using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.WinForms.Canvas
{
    interface ICanvas
    {
        Bitmap Bitmap { get; set; }
        int Height { get; set; }
        int Width { get; set; }
    }
}
