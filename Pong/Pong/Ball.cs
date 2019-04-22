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
        private List<Point> points;
        private Brush brush;
        private Point velocity;

        public Ball (Graphics graphics, Size ClientSize)
        {
            this.graphics = graphics;
        }
        public void Draw()
        {

        }
        public void Move()
        {

        }
        public void Bounce()
        {

        }
    }
}
