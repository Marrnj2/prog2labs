using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    class Paddle
    {
        private Graphics graphics;
        private Brush brush;
        private Point position;
        private Size clientSize;
        public Paddle(Graphics graphics, Size ClientSize, Point point,Color color)
        {
            this.graphics = graphics;
            this.clientSize = ClientSize;
            this.position = point;
            brush = new SolidBrush(color);
        }
        public void Draw()
        {
            graphics.DrawRectangle(Pens.Black, new Rectangle(100, 50, 25, 100));
            graphics.FillRectangle(Brushes.Black, new Rectangle(100, 50, 25, 100));
        }
        public void Move()
        {

        }
    }
}
