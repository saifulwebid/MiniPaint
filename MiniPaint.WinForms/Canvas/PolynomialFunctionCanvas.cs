using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MiniPaint.WinForms.DrawingObject;

namespace MiniPaint.WinForms.Canvas
{
    class PolynomialFunctionCanvas : Canvas
    {
        private Axis axis;
        private Color axisColor;
        private int scale;

        public ObservableCollection<PolynomialFunction> Objects { get; set; }
        public Color AxisColor
        {
            get { return axisColor; }
            set
            {
                axisColor = value;
                axis.ForegroundColor = value;
                GenerateBitmap();
            }
        }
        public int Scale
        {
            get { return scale; }
            set
            {
                scale = value;
                axis.Scale = value;
                GenerateBitmap();
            }
        }

        public PolynomialFunctionCanvas(int width, int height, Color axisColor) : base(width, height)
        {
            Objects = new ObservableCollection<PolynomialFunction>();
            axis = new Axis(width, height, (1 << 6), axisColor);

            AxisColor = axis.ForegroundColor;
            Scale = axis.Scale;

            Objects.CollectionChanged += Objects_CollectionChanged;
        }

        private void Objects_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            GenerateBitmap();
        }

        public override void Clear()
        {
            Bitmap.Dispose();
            Bitmap = new Bitmap(Width, Height);

            OnBitmapChanged();
        }

        private void GenerateBitmap()
        {
            Clear();
            
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                axis.Draw(g);
                foreach (PolynomialFunction f in Objects)
                {
                    f.Draw(g);
                }
            }

            OnBitmapChanged();
        }
    }
}
