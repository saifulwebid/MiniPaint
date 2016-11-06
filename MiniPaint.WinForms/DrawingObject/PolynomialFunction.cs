using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.DrawingObject
{
    class PolynomialFunction : IDrawable
    {
        private double[] constants;
        public int Height, Width;
        public int Scale;

        public PolynomialFunction(double[] constants, int height, int width, int scale)
        {
            this.constants = constants;
            Height = height;
            Width = width;
            Scale = scale;
        }

        public void ResetAxisSize(int height, int width)
        {
            Height = height;
            Width = width;
        }

        private double yResult(double x)
        {
            double result = 0;
            for (int i = 0; i < constants.Length; i++)
            {
                double xPower = 1;
                for (int j = 1; j <= i; j++)
                {
                    xPower = xPower * x;
                }
                result += constants[i] * xPower;
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
                    new LineGenerator.Dda(new Line(new Point(x_prev + center.X, y_prev), new Point(x + center.X, y))).Draw(g);

                x_prev = x;
                y_prev = y;
            }

            x_prev = 0;
            y_prev = yPlotter(x_prev);

            for (int x = -1; x >= -center.X; x--)
            {
                int y = yPlotter(x);

                if (y_prev >= 0 && y_prev <= Height)
                    new LineGenerator.Dda(new Line(new Point(x_prev + center.X, y_prev), new Point(x + center.X, y))).Draw(g);

                x_prev = x;
                y_prev = y;
            }
        }
    }
}
