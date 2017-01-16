using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.Transformation;

namespace MiniPaint.WinForms.Action
{
    class ApplyTransformationMatrix : IAction
    {
        private ITransformable drawableObject;
        private Matrix transformationMatrix;

        public ApplyTransformationMatrix(ITransformable o, Matrix m)
        {
            drawableObject = o;
            transformationMatrix = m;
        }
        
        public void Do()
        {
            drawableObject.TransformationMatrix.Apply(transformationMatrix);
        }
    }
}
