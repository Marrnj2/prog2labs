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
        private Random random;
        public PictureBox[] pictureBoxes;
        public Controller controller;



        public Form1()
        {
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
            controller.StartRace();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controller.Race();
            if(controller.RaceOver == true)
            {
                timer1.Enabled = false;
            }
        }
    }
}
