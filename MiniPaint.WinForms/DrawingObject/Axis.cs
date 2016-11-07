using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.DrawingObject
{
    class Axis : IDrawable
    {
        public int Height, Width;
        public int Scale;

        public Axis(int height, int width, int scale)
        {
            Height = height;
            Width = width;
            Scale = scale;
        }

        public void ResetAxisSize(int height, int width)
        {
            Height = height;
            Width = width;
        }
        
        public void Draw(Graphics g, Color c)
        {
            Point center = new Point(Width / 2, Height / 2);

            new LineGenerator.Bresenham(new Line(new Point(0, center.Y), new Point(Width, center.Y))).Draw(g, c);
            new LineGenerator.Bresenham(new Line(new Point(center.X, 0), new Point(center.X, Height))).Draw(g, c);

            int x, y;
            for (x = center.X + Scale; x <= Width; x += Scale)
            {
                new LineGenerator.Bresenham(new Line(new Point(x, center.Y - 5), new Point(x, center.Y + 5))).Draw(g, c);
            }
            for (x = center.X - Scale; x >= 0; x -= Scale)
            {
                new LineGenerator.Bresenham(new Line(new Point(x, center.Y - 5), new Point(x, center.Y + 5))).Draw(g, c);
            }
            for (y = center.Y + Scale; y <= Height; y += Scale)
            {
                new LineGenerator.Bresenham(new Line(new Point(center.X - 5, y), new Point(center.X + 5, y))).Draw(g, c);
            }
            for (y = center.Y - Scale; y >= 0; y -= Scale)
            {
                new LineGenerator.Bresenham(new Line(new Point(center.X - 5, y), new Point(center.X + 5, y))).Draw(g, c);
            }
        }
    }
}
