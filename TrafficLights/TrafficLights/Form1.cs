using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Light light;
        private TrafficLight trafficLight;



        public Form1()
        {
            InitializeComponent();

            graphics = CreateGraphics();
            
 

            trafficLight = new TrafficLight(graphics);

        }

        private void traditionalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trafficLight.Flash();
        }
    }
}
