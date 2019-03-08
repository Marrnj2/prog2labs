using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsAndTails
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        private Coin coin;
        public Form1()
        {
            InitializeComponent();
           
            coin = new Coin(random);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
  
                coin = new Coin(random);
                coin.Throw();
                listBox1.Items.Add(coin.SideUp);
            }
        }
    }
}
