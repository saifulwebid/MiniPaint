using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.Transformation;

namespace MiniPaint.WinForms
{
    interface ITransformable
    {
        Matrix TransformationMatrix { get; set; }
    }
}
