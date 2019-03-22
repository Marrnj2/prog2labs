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
        private Path path;
        private Graphics graphics;
        private Pen pen;
        private Robot robot;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            pen = new Pen(Brushes.Blue, 4.0F);
            path = new Path(graphics, pen);
            robot = new Robot(pictureBox1);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            path.StartPath(e.Location);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            path.StopPath();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            path.DrawPath(e.Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            robot.WalkPath(path);
        }
        //e.Location is the current position of the mouse
        // e.location is store as point (x.y)
    }
}
