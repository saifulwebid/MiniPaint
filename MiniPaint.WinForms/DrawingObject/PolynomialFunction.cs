using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.LineGenerator;

namespace MiniPaint.WinForms.DrawingObject
{
    class PolynomialFunction : IDrawable
    {
        public double[] Constants { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Scale { get; set; }
        public Color ForegroundColor { get; set; }

        public PolynomialFunction(double[] constants, int height, int width, int scale, Color c)
        {
            Constants = constants;
            Height = height;
            Width = width;
            Scale = scale;
            ForegroundColor = c;
        }

        public void ResetAxisSize(int height, int width)
        {
            Height = height;
            Width = width;
        }

        private double yResult(double x)
        {
            double result = 0;
            double xPower = 1;
            for (int i = 0; i < Constants.Length; i++)
            {
                result += Constants[i] * xPower;
                xPower *= x;
            }
            return result;
        }

        private int yPlotter(double x)
        {
            int center = Height / 2;

            return center - (int)(yResult(x / Scale) * Scale);
        }

        public void Draw(Graphics g)
        {
            Point center = new Point(Width / 2, Height / 2);

            int x_prev = 0;
            int y_prev = yPlotter(x_prev);

            for (int x = 1; x <= Width - center.X; x++)
            {
                int y = yPlotter(x);

                if (y_prev >= 0 && y_prev <= Height)
                    new Line(new Point(x_prev + center.X, y_prev), new Point(x + center.X, y), ForegroundColor, new Dda()).Draw(g);

                x_prev = x;
                y_prev = y;
            }

            x_prev = 0;
            y_prev = yPlotter(x_prev);

            for (int x = -1; x >= -center.X; x--)
            {
                int y = yPlotter(x);

                if (y_prev >= 0 && y_prev <= Height)
                    new Line(new Point(x_prev + center.X, y_prev), new Point(x + center.X, y), ForegroundColor, new Dda()).Draw(g);

                x_prev = x;
                y_prev = y;
            }
        }
    }
}
