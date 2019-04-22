using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PlayingCards
{
    class Card
    {
        private eRank rank;
        private eSuit suit;
        private Image image;

        public Card(eRank rank, eSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
            image = (Bitmap)Properties.Resources.ResourceManager.GetObject(rank.ToString() + suit.ToString());
        }
        public override string ToString()
        {
            return (rank.ToString() + " of " + suit.ToString());
        }

        public Image Image { get => image; set => image = value; }
    }
}
