﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.WinForms
{
    interface IDrawable
    {
        void Draw(Graphics g, Color c);
    }
}
