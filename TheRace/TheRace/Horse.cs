using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TheRace
{
    public class Horse
    {
        public const int MAXSPEED = 100;
        private const int STARTPOS = 60;

        private string name;
        private PictureBox pictureBox;
        public int finishLine;
        public Random random;


        public Horse(PictureBox pictureBox, Random random, int finishLine, string name)
        {
            this.pictureBox = pictureBox;
            this.random = random;
            this.finishLine = finishLine;
            this.name = name;
        }
        public void Move()
        {
           int speed = random.Next(MAXSPEED);
           pictureBox.Left += speed;
        }
        public bool CheckForWinner()
        {
            if (pictureBox.Left + pictureBox.Width >= finishLine)
            {
                return true;
            }
            return false;
        }
        public void Restart()
        {
            pictureBox.Left = 21;
        }
        public string Name { get => name; set => name = value; }

    }
}
