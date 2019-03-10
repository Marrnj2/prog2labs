// Uses a random number to generate heads or tails
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace HeadsAndTails
{
    public class Coin
    {
        // Constatns
        private const int NRANDOM = 2;

        // Feilds
        private string sideUp;
        private Random random;

        public Coin(Random random)
        {
            // Initilalise feilds
            this.random = random;
        }

        public void Throw()
        {
            // Creates a random number then assings heads or tails based off of the result
            int toss = random.Next(NRANDOM);
            if(toss == 1)
            {
                this.sideUp = "Heads";
            }
            else
            {
                this.sideUp = "Tails";
            }
        }
        public string SideUp { get => sideUp; set => sideUp = value; }

    }
}
