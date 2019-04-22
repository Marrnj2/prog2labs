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
    class Ball
    {
        private const int SIZE = 30;
        private const int CHANGEDIRECTION = -1;


        private Graphics graphics;
        private Point position;
        private Brush brush;
        private Point velocity;
        private Size clientSize;

        public Ball (Graphics graphics, Size ClientSize, Point velocity, Point position, Color color)
        {
            this.graphics = graphics;
            this.clientSize = ClientSize;
            this.velocity = velocity;
            this.position = position;
            brush = new SolidBrush(color);
        }
        public void Draw()
        {
            graphics.FillEllipse(brush, position.X, position.Y, SIZE, SIZE);
        }
        public void Move()
        {
            position.X += velocity.X;
            position.Y += velocity.Y;
        }
        public void Bounce()
        {
            if (position.X <= 0)
            {
                velocity.X *= -1;
            }
            if (position.Y <= 0)
            {
                velocity.Y *= -1;
            }
            if (position.X + SIZE > clientSize.Width)
            {
                velocity.X *= -1;
            }
            if (position.Y + SIZE > clientSize.Height)
            {
                velocity.Y *= -1;
            }
        }
    }
}
