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
        private string sideUp;
        private Random random;

        public Coin(Random random)
        {
            this.random = random;
        }

        public string SideUp { get => sideUp; set => sideUp = value; }

        public void Throw()
        {
            int toss = random.Next(2);
            if(toss == 1)
            {
                this.sideUp = "Heads";
            }
            else
            {
                this.sideUp = "Tails";
            }
        }
            
    }
}
