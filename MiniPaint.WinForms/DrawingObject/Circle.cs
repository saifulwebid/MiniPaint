using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.DrawingObject
{
    class Circle : IDrawable
    {
        private Point center;
        private int radius;

        public Circle(Point center, int radius)
        {
            this.center = center;
            this.radius = radius;
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
            g.FillRectangle(Brushes.Purple, new Rectangle(new Point(x + this.center.X, y + this.center.Y), new Size(1, 1)));
            g.FillRectangle(Brushes.Purple, new Rectangle(new Point(-x + this.center.X, y + this.center.Y), new Size(1, 1)));
            g.FillRectangle(Brushes.Purple, new Rectangle(new Point(x + this.center.X, -y + this.center.Y), new Size(1, 1)));
            g.FillRectangle(Brushes.Purple, new Rectangle(new Point(-x + this.center.X, -y + this.center.Y), new Size(1, 1)));
            g.FillRectangle(Brushes.Purple, new Rectangle(new Point(y + this.center.X, x + this.center.Y), new Size(1, 1)));
            g.FillRectangle(Brushes.Purple, new Rectangle(new Point(-y + this.center.X, x + this.center.Y), new Size(1, 1)));
            g.FillRectangle(Brushes.Purple, new Rectangle(new Point(y + this.center.X, -x + this.center.Y), new Size(1, 1)));
            g.FillRectangle(Brushes.Purple, new Rectangle(new Point(-y + this.center.X, -x + this.center.Y), new Size(1, 1)));
        }
    }
}
