
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

namespace RoboTracker
{
    class Robot
    {
        // Feilds
        private const int MILLSECONDS = 10;
        PictureBox pictureBox;
        public Robot(PictureBox pictureBox)
        {
            // Initilizing feilds 
            this.pictureBox = pictureBox;
        }
        public void WalkPath(Path path)
        {
            // Gets the robot to follow the line drawn by the user
            foreach (Point point in path.Points)
            {
                pictureBox.Top = point.Y - (pictureBox.Height / 2);
                pictureBox.Left = point.X - (pictureBox.Width / 2);
                Application.DoEvents();
                Thread.Sleep(MILLSECONDS);
                
            }
        }
    }
}
