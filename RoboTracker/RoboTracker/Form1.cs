/*
 * Program Name:        RoboTracker
 * Project file name:   RoboTracker
 * Author:              Nicholas Marr
 * Date:                26/03/2019
 * Language:            C#
 * Platform:            Microsoft Visual Studio 2017
 * Purpose:             To destroy messy lines
 * Description:         A seal travels in search for a snack
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

namespace RoboTracker
{
    
    public partial class Form1 : Form
    {
        // Feilds
        private Path path;
        private Graphics graphics;
        private Pen pen;
        private Robot robot;

        public Form1()
        {
            // Initilizing feilds 
            InitializeComponent();
            graphics = CreateGraphics();
            pen = new Pen(Brushes.Blue, 4.0F);
            path = new Path(graphics, pen);
            robot = new Robot(pictureBox1);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Calls the start path method 
            path.StartPath(e.Location);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Calls the path stop method 
            path.StopPath();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Calls the draw path method
            path.DrawPath(e.Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calls the WalkPath method
            robot.WalkPath(path);
        }
        //e.Location is the current position of the mouse
        // e.location is store as point (x.y)
    }
}
