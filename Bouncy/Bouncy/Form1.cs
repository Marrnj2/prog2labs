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
        public Form1()
        {
            
           
            InitializeComponent();
            graphics = CreateGraphics();
            world = new World(graphics, ClientSize);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            world.Run();
        }
    }
}
