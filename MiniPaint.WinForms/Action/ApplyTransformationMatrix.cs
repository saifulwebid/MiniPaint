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
        private frmMain form;
        private int index;
        private Matrix transformationMatrix;

        public ApplyTransformationMatrix(frmMain f, int i, Matrix m)
        {
            form = f;
            index = i;

            Matrix objectTransMatrix = ((ITransformable)form.GeometryObjects[index]).TransformationMatrix;
            objectTransMatrix = new Matrix(objectTransMatrix.M11,
                objectTransMatrix.M12,
                objectTransMatrix.M21,
                objectTransMatrix.M22,
                objectTransMatrix.OffsetX,
                objectTransMatrix.OffsetY);
            objectTransMatrix.Apply(m);
            transformationMatrix = objectTransMatrix;
        }
        
        public void Do()
        {
            ((ITransformable)form.GeometryObjects[index]).TransformationMatrix = transformationMatrix;
        }
    }
}
