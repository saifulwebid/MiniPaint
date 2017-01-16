using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.Transformation;

namespace MiniPaint.WinForms.DrawingObject
{
    class Circle : IDrawable, ITransformable
    {
        private Point center;
        private int radius;

        public Color ForegroundColor { get; set; }
        public Matrix TransformationMatrix { get; set; }
        public string DisplayText
        {
            get
            {
                return string.Format("Circle at ({0}, {1}), r: {2}", center.X, center.Y, radius);
            }
        }

        public Circle(Point center, int radius, Color c)
        {
            this.center = center;
            this.radius = radius;
            ForegroundColor = c;
            TransformationMatrix = Matrix.Identity;
        }

        public void Draw(Graphics g)
        {
            int x = 0;
            int y = this.radius;
            int p = 1 - this.radius;

            while (x < y)
            {
                drawCirclePoints(x, y, g);

                x++;
                if (p < 0)
                {
                    p = p + 2 * x + 1;
                }
                else
                {
                    y--;
                    p = p + 2 * (x - y) + 1;
                }
            }

            drawCirclePoints(x, y, g);
        }

        private void drawCirclePoints(int x, int y, Graphics g)
        {
            Brush br = new SolidBrush(ForegroundColor);
            Size sz = new Size(1, 1);

            g.FillRectangle(br, new Rectangle(TransformationMatrix.Transform(new Point(x + this.center.X, y + this.center.Y)), sz));
            g.FillRectangle(br, new Rectangle(TransformationMatrix.Transform(new Point(-x + this.center.X, y + this.center.Y)), sz));
            g.FillRectangle(br, new Rectangle(TransformationMatrix.Transform(new Point(x + this.center.X, -y + this.center.Y)), sz));
            g.FillRectangle(br, new Rectangle(TransformationMatrix.Transform(new Point(-x + this.center.X, -y + this.center.Y)), sz));
            g.FillRectangle(br, new Rectangle(TransformationMatrix.Transform(new Point(y + this.center.X, x + this.center.Y)), sz));
            g.FillRectangle(br, new Rectangle(TransformationMatrix.Transform(new Point(-y + this.center.X, x + this.center.Y)), sz));
            g.FillRectangle(br, new Rectangle(TransformationMatrix.Transform(new Point(y + this.center.X, -x + this.center.Y)), sz));
            g.FillRectangle(br, new Rectangle(TransformationMatrix.Transform(new Point(-y + this.center.X, -x + this.center.Y)), sz));
        }
    }
}
