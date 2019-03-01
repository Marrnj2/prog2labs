/*
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

namespace SpriteAnimation
{
    public partial class Form1 : Form
    {
        private Animator animator;
        public Form1()
        {
            InitializeComponent();

            animator = new Animator(pictureBox1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Plays a spirte animation on click
            animator.LoadImages();
        }
    }
}
