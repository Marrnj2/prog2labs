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
        private int score;
        private int velocity = 10;
        private Ball ball;
        private TextBox textBox1;
        private TextBox textBox2;
        private Size clientSize;

        public World (Graphics graphics, Size ClientSize, TextBox textBox1, TextBox textBox2)
        {
            ball = new Ball(graphics, ClientSize, new Point(velocity, velocity), new Point(500, 300), Color.Wheat);
            this.textBox1 = textBox1;
            this.textBox2 = textBox2;
            this.clientSize = ClientSize;
        }
        public void Run()
        {

            ball.Move();
            ball.Bounce();
            ball.Draw();
            CheckForScore();
        }
        public void CheckForScore()
        {
            int score;
            if (ball.Position.X <= 0)
            {
                score = Convert.ToInt32(textBox1.Text);
                score++;
                textBox1.Text = score.ToString();
            }
            if (ball.Position.X > clientSize.Width)
            {
                score = Convert.ToInt32(textBox2.Text);
                score++;
                textBox2.Text = score.ToString();
            }
        }
        public void ResetBall()
        {
            
        }
    }
}
