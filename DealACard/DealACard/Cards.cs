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
        // Constatns
        private const int NSUIT = 4;
        private const int HIGH = 14;
        private const int LOW = 1;

        // Feild initialization
        private PictureBox pictureBox;
        private int rank;
        private int suit;
        private Random random;
        private Label label;
        private string imageload;
        private string suitString;



        public Cards(Random random, PictureBox pictureBox, Label label)
        {
            this.pictureBox = pictureBox;
            this.random = random;
            this.label = label;

        }
        public void DealACard()
        {
            // Calls submethods used to pick a random playing card
            chooseAcard();
            loadPictureBox();
            writeToLabel();
        }
        private void chooseAcard()
        {
            // Creates the string that will be used to find a card from the resource files

            suit = random.Next(NSUIT);
            rank = random.Next(LOW, HIGH);
            suitString = "";
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
            imageload = (suitString + rank.ToString());
        }

        private void loadPictureBox()
        {
            // Loads a picture in to the picturebox 
            pictureBox.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(imageload);
        }

        private void writeToLabel()
        {
            // Creates a string that will be used to display the name of a card
            string name;
            string number;
            switch (suitString)
            {
                case "D":
                    name = "of Diamonds";
                    break;
                case "C":
                    name = "of Clubs";
                    break;
                case "S":
                    name = "of Spades";
                    break;
                case "H":
                    name = "of Hearts";
                    break;
                
                default:
                    name = "Unkown suit";
                    break;
            }
            switch (rank)
            {
                case 1:
                    number = "Ace";
                    break;
                case 11:
                    number = "Jack";
                    break;
                case 12:
                    number = "Queen";
                    break;
                case 13:
                    number = "King";
                    break;

                default:
                    number = rank.ToString();
                    break;
            }
            label.Text = (number+ " " + name);
        }
    }
}
