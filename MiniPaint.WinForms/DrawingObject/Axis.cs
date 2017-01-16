using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.LineGenerator;

namespace MiniPaint.WinForms.DrawingObject
{
    class Axis : IDrawable
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Scale { get; set; }
        public Color ForegroundColor { get; set; }

        public Axis(int width, int height, int scale, Color fg)
        {
            Height = height;
            Width = width;
            Scale = scale;
            ForegroundColor = fg;
        }

        public void ResetAxisSize(int width, int height)
        {
            Height = height;
            Width = width;
        }
        
        public void Draw(Graphics g)
        {
            Point center = new Point(Width / 2, Height / 2);

            new Line(new Point(0, center.Y), new Point(Width, center.Y), ForegroundColor, new Bresenham()).Draw(g);
            new Line(new Point(center.X, 0), new Point(center.X, Height), ForegroundColor, new Bresenham()).Draw(g);

            int x, y;
            for (x = center.X + Scale; x <= Width; x += Scale)
            {
                new Line(new Point(x, center.Y - 5), new Point(x, center.Y + 5), ForegroundColor, new Bresenham()).Draw(g);
            }
            for (x = center.X - Scale; x >= 0; x -= Scale)
            {
                new Line(new Point(x, center.Y - 5), new Point(x, center.Y + 5), ForegroundColor, new Bresenham()).Draw(g);
            }
            for (y = center.Y + Scale; y <= Height; y += Scale)
            {
                new Line(new Point(center.X - 5, y), new Point(center.X + 5, y), ForegroundColor, new Bresenham()).Draw(g);
            }
            for (y = center.Y - Scale; y >= 0; y -= Scale)
            {
                new Line(new Point(center.X - 5, y), new Point(center.X + 5, y), ForegroundColor, new Bresenham()).Draw(g);
            }
        }
    }
}
