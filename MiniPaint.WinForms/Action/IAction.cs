﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.WinForms.Action
{
    interface IAction
    {
        void Do(Graphics g);
    }
}