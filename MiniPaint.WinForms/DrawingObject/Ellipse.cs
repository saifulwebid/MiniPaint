﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaint.WinForms.DrawingObject
{
    class Ellipse : IDrawable
    {
        private Point center;
        private int rx, ry;

        public Ellipse(Point center, int rx, int ry)
        {
            this.center = center;
            this.rx = rx;
            this.ry = ry;
        }

        public void Draw(Graphics g)
        {
            int x = 0;
            int y = ry;
            drawPoints(x, y, g);

            int p = ry * ry - rx * rx * ry + (rx * rx) / 4;
            while (2 * ry * ry * x < 2 * rx * rx * y)
            {
                x++;
                p += 2 * ry * ry * x + ry * ry;

                if (p >= 0)
                {
                    y--;
                    p -= 2 * rx * rx * y;
                }

                drawPoints(x, y, g);
            }

            p = (int)(ry * ry * (x + 0.5) * (x + 0.5) + rx * rx * (y - 1) * (y - 1) - rx * rx * ry * ry);
            while (y > 0)
            {
                y--;
                p += rx * rx - 2 * rx * rx * y;

                if (p <= 0)
                {
                    x++;
                    p += 2 * ry * ry * x;
                }

                drawPoints(x, y, g);
            }
        }

        private void drawPoints(int x, int y, Graphics g)
        {
            g.FillRectangle(Brushes.RoyalBlue, new Rectangle(new Point(x + this.center.X, y + this.center.Y), new Size(1, 1)));
            g.FillRectangle(Brushes.RoyalBlue, new Rectangle(new Point(-x + this.center.X, y + this.center.Y), new Size(1, 1)));
            g.FillRectangle(Brushes.RoyalBlue, new Rectangle(new Point(x + this.center.X, -y + this.center.Y), new Size(1, 1)));
            g.FillRectangle(Brushes.RoyalBlue, new Rectangle(new Point(-x + this.center.X, -y + this.center.Y), new Size(1, 1)));
        }
    }
}