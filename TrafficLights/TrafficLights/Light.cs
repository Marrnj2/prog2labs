using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TrafficLights
{
    class Light
    {
        private const int SIZE = 50;
        private Point point;
        private Color color;
        private Brush brush;
        private int interval = 1000;
        private Graphics graphics;

        public Color Color { get => color; set => color = value; }

        public Light(Point point, Graphics graphics, Color color)
        {
            this.graphics = graphics;
            this.point = point;
            brush = new SolidBrush(color);
            interval = new int();
        }

        public void Flash()
        {
            Draw(color);
            Application.DoEvents();
            Thread.Sleep(interval);
            Draw(Color.Black);
        }
        public void Draw(Color newColor)
        {
            Brush brush = new SolidBrush(newColor);
            graphics.FillEllipse(brush, new Rectangle(point.X, point.Y, SIZE, SIZE));
        }
    }
}
