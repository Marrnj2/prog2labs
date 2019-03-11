/*
 * Program Name:        Slot Machine   
 * Project file name:   SlotMachine
 * Author:              Nicholas Marr
 * Date:                12/03/2019
 * Language:            C#
 * Platform:            Microsoft Visual Studio 2017
 * Purpose:             To learn about class's and objects 
 * Description:         A slot machine based gambling game
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
using System.Threading;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        // Constant Decleration
        private const int LOSS = 10;
        private const int START = 100;
        private const int GAIN = 50;
        private const int NMILIISECONDS = 100;
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

            // Initilizing feilds 
            slot1 = new Slot(random,pictureBox1);
            slot2 = new Slot(random,pictureBox2);
            slot3 = new Slot(random,pictureBox3);
            winnings = START;
            textBox2.Text = (winnings.ToString("C"));     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checks to see if the player has enough money to play, spins the slot machine slots
            // Then checks to see if the player won or lost money.

            slot1 = new Slot(random, pictureBox1);
            slot2 = new Slot(random, pictureBox2);
            slot3 = new Slot(random, pictureBox3);
            button1.Enabled = false;
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
                if ((slot1.ImageNumber == slot2.ImageNumber) && (slot1.ImageNumber == slot3.ImageNumber))
                {
                    textBox1.Text = "You win!";
                    winnings += GAIN;
                    textBox2.Text = winnings.ToString("C");
                }
                else
                {
                    textBox1.Text = "You lose";
                }
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("No money go home");
                Application.Exit();
            }
        }
    }
}
