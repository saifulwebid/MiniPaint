using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.Canvas;

namespace MiniPaint.WinForms.DrawingObject
{
    class FloodFill : IDrawable
    {
        private Point seedPoint;
        private DrawingCanvas canvas;

        public string DisplayText
        {
            get { return "Flood fill"; }
        }

        public Color ForegroundColor { get; set; }

        public FloodFill(Point seedPoint, Color newColor, DrawingCanvas c)
        {
            this.seedPoint = seedPoint;
            ForegroundColor = newColor;
            canvas = c;
        }

        public void Draw(Graphics g)
        {
            /* Initialize put-pixel operation */
            Brush br = new SolidBrush(ForegroundColor);
            Size sz = new Size(1, 1);

            /* Get old bitmap */
            Bitmap bmp = canvas.Bitmap;
            Color oldColor = bmp.GetPixel(seedPoint.X, seedPoint.Y);

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
                    if (currentColor.ToArgb() != oldColor.ToArgb())
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
