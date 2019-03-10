using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealACard
{
    public partial class Form1 : Form
    {
        private Cards card;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            card = new Cards(random,pictureBox1, label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            card = new Cards(random, pictureBox1, label1);
            card.DealACard();
        }
    }
}
