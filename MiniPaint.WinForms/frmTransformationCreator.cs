using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniPaint.WinForms.DrawingObject;
using MiniPaint.WinForms.Transformation;

namespace MiniPaint.WinForms
{
    public partial class frmTransformationCreator : Form
    {
        internal Matrix TransformationMatrix { get; private set; }

        public frmTransformationCreator()
        {
            InitializeComponent();

            TransformationMatrix = null;
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            switch (tbcTransformation.SelectedIndex)
            {
                case 0: // Translasi
                    int dx = int.Parse(txtTranslationDx.Text);
                    int dy = int.Parse(txtTranslationDy.Text);
                    TransformationMatrix = TranslationMatrixFactory.CreateMatrix(dx, dy);
                    break;

                case 1: // Dilatasi
                    double sc = double.Parse(txtScalingConstant.Text);
                    TransformationMatrix = ScalingMatrixFactory.CreateMatrix(sc);
                    break;

                case 2: // Rotasi
                    double angle = double.Parse(txtRotationAngleInDegrees.Text) * Math.PI / 180;
                    TransformationMatrix = RotationMatrixFactory.CreateMatrix(angle);
                    break;

                case 3: // Refleksi
                    int sx = int.Parse(txtReflectionStartX.Text);
                    int sy = int.Parse(txtReflectionStartY.Text);
                    int ex = int.Parse(txtReflectionEndX.Text);
                    int ey = int.Parse(txtReflectionEndY.Text);
                    Line l = new Line(new Point(sx, sy), new Point(ex, ey), Color.Black, null);

                    TransformationMatrix = ReflectionMatrixFactory.CreateMatrix(l);
                    break;
            }

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
