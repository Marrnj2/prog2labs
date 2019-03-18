using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(Pens.Green, new Point(10, 10), new Point(80, 80));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(Pens.Green, new Point(60, 10), new Point(20, 100));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.FillRectangle(Brushes.Red, new Rectangle(100, 20, 100, 50));
            graphics.DrawRectangle(Pens.Black, new Rectangle(100, 20, 100, 50));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphics.DrawEllipse(Pens.Maroon, new Rectangle(50, 200, 160, 80));
            graphics.FillEllipse(Brushes.Maroon, new Rectangle(50, 200, 160, 80));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Font font = new Font("Consolas", 15, FontStyle.Regular);
            graphics.DrawString("This is fun?", font, Brushes.Black, new Point(60, 225));
        }
    }
}
