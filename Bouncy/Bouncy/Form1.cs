using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bouncy
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private World world;
        private Bitmap bufferImage;
        private Graphics bufferGraphics;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            world = new World(graphics, ClientSize);
            timer1.Enabled = true;
            bufferImage = new Bitmap(Width, Height);
            bufferGraphics = Graphics.FromImage(bufferImage);
            world = new World(bufferGraphics, ClientSize);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bufferGraphics.FillRectangle(Brushes.LimeGreen, 0, 0, Width, Height);
            world.Run();
            graphics.DrawImage(bufferImage, 0, 0);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            world.ChangeSpeed(trackBar1.Value, 0);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            world.ChangeSpeed(trackBar2.Value, 1);
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            world.ChangeSpeed(trackBar3.Value, 2);
        }
    }
}
