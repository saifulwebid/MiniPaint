﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniPaint.WinForms.Canvas
{
    abstract class Canvas
    {
        private int height;
        private int width;

        public Bitmap Bitmap { get; set; }
        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                Resize();
            }
        }
        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                Resize();
            }
        }

        public event EventHandler BitmapChanged;

        public Canvas(int width, int height)
        {
            Bitmap = new Bitmap(width, height);
            this.height = height;
            this.width = width;
        }

        protected void OnBitmapChanged()
        {
            EventHandler handler = BitmapChanged;

            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        protected virtual void Resize()
        {
            Bitmap newBitmap = new Bitmap(Width, Height);

            if (Bitmap != null)
            {
                using (Graphics g = Graphics.FromImage(newBitmap))
                {
                    g.DrawImage(Bitmap, 0, 0);
                }
                Bitmap.Dispose();
            }
            Bitmap = newBitmap;
            OnBitmapChanged();
        }

        public abstract void Clear();
    }
}
