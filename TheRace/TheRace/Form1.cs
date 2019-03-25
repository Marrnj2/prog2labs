/*
 * Program Name:        TheRace    
 * Project file name:   TheRace
 * Author:              Nicholas Marr
 * Date:                26/03/2019
 * Language:            C#
 * Platform:            Microsoft Visual Studio 2017
 * Purpose:             To persuade childern into gambling  
 * Description:         The loney toons go to the casino
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

namespace TheRace
{
    public partial class Form1 : Form
    {
        // Feilds
        private Random random;
        public PictureBox[] pictureBoxes;
        public Controller controller;



        public Form1()
        {
            //  Initializing feilds 
            InitializeComponent();
            pictureBoxes = new PictureBox[4];
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;

            random = new Random();
            int finishLine = panel1.Left;
            controller = new Controller(random,finishLine, pictureBoxes); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Calls the start race method, enalbes the timer 
            controller.StartRace();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Calls the Race method and checks to see if the race is over
            controller.Race();
            if(controller.RaceOver == true)
            {
                timer1.Enabled = false;
            }
        }
    }
}
