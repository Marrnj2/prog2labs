using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingCards
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private Hand hand;
        

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            hand = new Hand(random);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hand.DealAHand();
            pictureBox1.Image = hand.Cards[0].Image;
            textBox1.Text = hand.Cards[0].ToString().ToLower();
            pictureBox2.Image = hand.Cards[1].Image;
            textBox2.Text = hand.Cards[1].ToString().ToLower();
            pictureBox3.Image = hand.Cards[2].Image;
            textBox3.Text = hand.Cards[2].ToString().ToLower();
            pictureBox4.Image = hand.Cards[3].Image;
            textBox4.Text = hand.Cards[3].ToString().ToLower();
            pictureBox5.Image = hand.Cards[4].Image;
            textBox5.Text = hand.Cards[4].ToString().ToLower();

        }


    }
}
