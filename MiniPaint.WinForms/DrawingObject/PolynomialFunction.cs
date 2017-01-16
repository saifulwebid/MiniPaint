using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniPaint.WinForms.LineGenerator;
using MiniPaint.WinForms.Canvas;

namespace MiniPaint.WinForms.DrawingObject
{
    class PolynomialFunction : IDrawable
    {
        private PolynomialFunctionCanvas canvas;

        public double[] Constants { get; set; }
        public Color ForegroundColor { get; set; }

        public PolynomialFunction(double[] constants, PolynomialFunctionCanvas canvas, Color color)
        {
            Constants = constants;
            ForegroundColor = color;
            this.canvas = canvas;
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
            int center = canvas.Height / 2;

            return center - (int)(yResult(x / canvas.Scale) * canvas.Scale);
        }

        public void Draw(Graphics g)
        {
            Point center = new Point(canvas.Width / 2, canvas.Height / 2);

            int x_prev = 0;
            int y_prev = yPlotter(x_prev);

            for (int x = 1; x <= canvas.Width - center.X; x++)
            {
                int y = yPlotter(x);

                if (y_prev >= 0 && y_prev <= canvas.Height)
                    new Line(new Point(x_prev + center.X, y_prev), new Point(x + center.X, y), ForegroundColor, new Dda()).Draw(g);

                x_prev = x;
                y_prev = y;
            }

            x_prev = 0;
            y_prev = yPlotter(x_prev);

            for (int x = -1; x >= -center.X; x--)
            {
                int y = yPlotter(x);

                if (y_prev >= 0 && y_prev <= canvas.Height)
                    new Line(new Point(x_prev + center.X, y_prev), new Point(x + center.X, y), ForegroundColor, new Dda()).Draw(g);

                x_prev = x;
                y_prev = y;
            }
        }
    }
}
