using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingShapes
{
    public partial class Form1 : Form
    {
        private int move;

        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            move = 20;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (move >= 800)
            {
                move = 0;
            }


            if (checkBox1.Checked == true)
            {
                graphics.Clear(Color.White);
            }
            graphics.DrawEllipse(Pens.Black, new Rectangle(move, 125, 50, 50));
            graphics.FillEllipse(Brushes.DimGray, new Rectangle(move, 125, 50, 50));
            graphics.DrawEllipse(Pens.Black, new Rectangle(move, 200, 50, 50));
            graphics.FillEllipse(Brushes.Black, new Rectangle(move, 200, 50, 50));
            graphics.DrawEllipse(Pens.Black, new Rectangle(move, 275, 50, 50));
            graphics.FillEllipse(Brushes.Gray, new Rectangle(move, 275, 50, 50));
            move += 20;
        }

    }
}
