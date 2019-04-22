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
    class World
    {
        private int velocity = 5;
        private Ball ball;
        public World (Graphics graphics, Size ClientSize)
        {
            ball = new Ball(graphics, ClientSize, new Point(velocity, velocity), new Point(200, 200), Color.Wheat);

        }
        public void Run()
        {

            ball.Move();
            ball.Bounce();
            ball.Draw();
        }
    }
}
