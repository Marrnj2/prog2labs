using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        private const int LOSS = 10;
        private const int START = 100;
        private const int GAIN = 50;

        private const int NMILIISECONDS = 200;
        private const int NSPINS = 20;

        // Feilds
        private Slot slot1;
        private Slot slot2;
        private Slot slot3;
        private int winnings;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            slot1 = new Slot(random,pictureBox1);
            slot2 = new Slot(random,pictureBox2);
            slot3 = new Slot(random,pictureBox3);
            winnings = START;
            textBox2.Text = (winnings.ToString("C"));



            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slot1 = new Slot(random, pictureBox1);
            slot2 = new Slot(random, pictureBox2);
            slot3 = new Slot(random, pictureBox3);

            if (winnings > 0)
            {
                winnings -= LOSS;

                textBox2.Text = winnings.ToString("C");

                for (int i = 0; i < NSPINS; i++)
                {
                    slot1.Spin();
                    slot2.Spin();
                    slot3.Spin();
                    Application.DoEvents();
                    Thread.Sleep(NMILIISECONDS);
                }
               
            }
            else
            {
                MessageBox.Show("No money go home");
                
            }
        }
    }
}
