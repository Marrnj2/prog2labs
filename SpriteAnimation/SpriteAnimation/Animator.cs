using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SpriteAnimation
{
    public class Animator
    {
        // Feild Declaration

        private const int NIMAGES = 11;
        private Image[] images;
        private PictureBox pictureBox;

        public Animator(PictureBox pictureBox)
        {
            // Loops through images assigning them to a slot in an array

            images = new Image[NIMAGES];
            for(int i = 0; i < images.Length; i++)
            {
                images[i] = (Bitmap)Properties.Resources.ResourceManager.GetObject("T" + i.ToString());
            }
            this.pictureBox = pictureBox;
        }

        public void LoadImages()
        {
            // Loops through images applying them to the picturebox
            for(int i = 0; i < images.Length; i++)
            {
                pictureBox.Image = images[i];
                Application.DoEvents();
                Thread.Sleep(100);
            }
        }
    }

}
