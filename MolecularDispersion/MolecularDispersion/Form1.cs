using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MolecularDispersion
{
    public partial class Form1 : Form
    {
        private Random random;
        private Graphics graphics;
        private World world;
        
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            random = new Random();
            world = new World(random, graphics);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            world.Run();
        }
    }
}
