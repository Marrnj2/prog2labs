using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DealACard
{
    public class Cards
    {
        private Image image;
        private PictureBox pictureBox;
        private int rank;
        private int suit;
        private Random random;
        private Label label;
        public Cards(Random random, PictureBox pictureBox, Label label)
        {
            this.pictureBox = pictureBox;
            this.random = random;
            this.label = label;

        }
        public void DealACard()
        {
            chooseAcard();
            loadPictureBox();
            writeToLabel();
        }
        private void chooseAcard()
        {
            suit = random.Next(4);
            rank = random.Next(1, 14);
            string suitString = "";
            switch (suit)
            {
                case 0:
                    suitString = "D";
                    break;
                case 1:
                    suitString = "C";
                    break;
                case 2:
                    suitString = "H";
                    break;
                case 3:
                    suitString = "S";
                    break;

                default:
                    MessageBox.Show("Unkown Card");
                    break;
            }
            string imageload = (suitString + rank.ToString());
        }

        private void loadPictureBox()
        {

        }

        private string writeToLabel()
        {

        }
    }
}
