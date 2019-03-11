using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SlotMachine
{
    public class Slot
    {
        // Constatnts
        private const int NIMAGES = 3;

        // Feilds
        private Random random;
        private PictureBox pictureBox;
        private Image[] images;
        private int imageNumber;

        public Slot(Random random, PictureBox pictureBox)
        {
            // Feild initialization 

            this.random = random;
            this.pictureBox = pictureBox;

            images = new Image[NIMAGES];
            images[0] = Properties.Resources.sheep;
            images[1] = Properties.Resources.coyote;
            images[2] = Properties.Resources.tree;

            imageNumber = 0;
        }

        public void Spin()
        {
            // Selects a random image
            imageNumber = random.Next(NIMAGES);
            pictureBox.Image = images[imageNumber];
        }
        public int ImageNumber { get => imageNumber; set => imageNumber = value; }

    }
}
