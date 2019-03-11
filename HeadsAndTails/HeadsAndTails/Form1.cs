/*
 * Program Name:        Heads and Tails    
 * Project file name:   Heads and Tails
 * Author:              Nicholas Marr
 * Date:                8/03/2019
 * Language:            C#
 * Platform:            Microsoft Visual Studio 2017
 * Purpose:             To learn about class's and objects 
 * Description:         A simple heads or tails coin toss game
 * Known Bugs:          
 * Additional Features: 
 * 
 * */
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
        // Feilds.
        Random random = new Random();
        private Coin coin;

        public Form1()
        {
            InitializeComponent();
            // Initilalise feilds.
            coin = new Coin(random);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Uses the coin class to generate a heads or tails value and qppends it to a list 
            // repeats five times.
            listBox1.Items.Clear();
            for(int i = 0; i < 5; i++)
            {
                coin = new Coin(random);
                coin.Throw();
                listBox1.Items.Add(coin.SideUp);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exits program.
            MessageBox.Show("Bye!");
            Application.Exit();
        }
    }
}
