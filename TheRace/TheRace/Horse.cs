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
        // Constants
        public const int MAXSPEED = 100;
        private const int STARTPOS = 60;

        //Feilds 
        private string name;
        private PictureBox pictureBox;
        public int finishLine;
        public Random random;


        public Horse(PictureBox pictureBox, Random random, int finishLine, string name)
        {
            // Initializing Feilds
            this.pictureBox = pictureBox;
            this.random = random;
            this.finishLine = finishLine;
            this.name = name;
        }
        public void Move()
        {
            // Moves horses foward a random amount
           int speed = random.Next(MAXSPEED);
           pictureBox.Left += speed;
        }
        public bool CheckForWinner()
        {
            // Checks to see if a horse passed the finish line
            if (pictureBox.Left + pictureBox.Width >= finishLine)
            {
                return true;
            }
            return false;
        }
        public void Restart()
        {
            // Sets the starting position for the race
            pictureBox.Left = 21;
        }
        public string Name { get => name; set => name = value; }

    }
}
