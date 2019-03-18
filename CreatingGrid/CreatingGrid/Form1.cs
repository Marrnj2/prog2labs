using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingGrid
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Font font = new Font("Tahoma", 6, FontStyle.Regular);
            for (int x = 0; x < Width; x += 20)
            {
                graphics.DrawLine(Pens.Black, new Point(x, 0), new Point(x, Height));
                graphics.DrawString(x.ToString(), font, Brushes.Black, new Point(x,0));
            }
            for(int y = 0; y < Height; y += 20)
            {
                graphics.DrawLine(Pens.Black, new Point(0, y), new Point(Width, y));
                graphics.DrawString(y.ToString(), font, Brushes.Black, new Point(0, y));

            }
        }
    }
}
