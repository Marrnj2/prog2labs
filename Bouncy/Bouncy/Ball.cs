using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bouncy
{
    class Ball
    {
        private const int SIZE = 10;

        private Point position;
        private Brush brush;
        private Graphics graphics;
        private Point velocity;
        private Size clientSize;

        public Ball(Point position, Color color, Graphics graphics, Point velocity, Size clientSize)
        {
            this.graphics = graphics;
            this.position = position;
            this.velocity = velocity;
            brush = new SolidBrush(color);
            this.clientSize = clientSize;
            
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
            if(position.X <= 0)
            {
                velocity.X *= -1; 
            }
            if(position.Y <= 0)
            {
                velocity.Y *= -1;
            }
            if(position.X + SIZE > clientSize.Width)
            {
                velocity.X *= -1;
            }
            if(position.Y + SIZE > clientSize.Height)
            {
                velocity.Y *= -1;
            }
        }

    }
}
