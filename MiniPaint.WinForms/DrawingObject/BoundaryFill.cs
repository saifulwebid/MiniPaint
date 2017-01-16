using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.Canvas;

namespace MiniPaint.WinForms.DrawingObject
{
    class BoundaryFill : IDrawable
    {
        private Point seedPoint;
        private DrawingCanvas canvas;
        private Color boundaryColor;

        public string DisplayText
        {
            get { return "Boundary fill"; }
        }

        public Color ForegroundColor { get; set; }

        public BoundaryFill(Point seedPoint, Color newColor, Color boundaryColor, DrawingCanvas c)
        {
            this.seedPoint = seedPoint;
            ForegroundColor = newColor;
            this.boundaryColor = boundaryColor;
            canvas = c;
        }

        public void Draw(Graphics g)
        {
            /* Initialize put-pixel operation */
            Brush br = new SolidBrush(ForegroundColor);
            Size sz = new Size(1, 1);

            /* Get old bitmap */
            Bitmap bmp = canvas.Bitmap;

            Stack<Point> stack = new Stack<Point>();
            stack.Push(seedPoint);
            while (stack.Count > 0)
            {
                Point current = stack.Pop();
                bool execute = true;

                /* Base case */
                if (current.X < 0 || current.X > canvas.Width ||
                        current.Y < 0 || current.Y > canvas.Height)
                    execute = false;

                if (execute)
                {
                    Color currentColor = bmp.GetPixel(current.X, current.Y);
                    if (currentColor.ToArgb() == boundaryColor.ToArgb() ||
                            currentColor.ToArgb() == ForegroundColor.ToArgb())
                        execute = false;

                    if (execute)
                    {
                        /* Recurrence */
                        bmp.SetPixel(current.X, current.Y, ForegroundColor);

                        stack.Push(new Point(current.X + 1, current.Y));
                        stack.Push(new Point(current.X - 1, current.Y));
                        stack.Push(new Point(current.X, current.Y + 1));
                        stack.Push(new Point(current.X, current.Y - 1));
                    }
                }
            }
        }
    }
}
