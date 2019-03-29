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
    class World
    {
        private const int velocity = 5;

        private List<Ball> balls;
        
        public World (Graphics graphics, Size ClientSize)
        {
            
            balls = new List<Ball>();
            balls.Add(new Ball(new Point(100, 100), Color.BlueViolet, graphics, new Point(velocity, velocity), ClientSize));
            balls.Add(new Ball(new Point(200, 300), Color.Black, graphics, new Point(velocity, velocity), ClientSize));
            balls.Add(new Ball(new Point(300, 150), Color.Gainsboro, graphics, new Point(velocity, velocity), ClientSize));
        }
        public void Run()
        {
            foreach (Ball ball in balls)
            {
                
                ball.Move();
                ball.Bounce();
                ball.Draw();
            }
        }
    }
}
