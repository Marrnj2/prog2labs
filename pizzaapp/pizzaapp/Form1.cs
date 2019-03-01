using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                listBox1.Items.Add("Olives");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radiobutton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobutton1.Checked)
            {
                listBox1.Items.Add("Small Pizza");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                listBox1.Items.Add("Anchovies");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                listBox1.Items.Add("Extra Cheese");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                listBox1.Items.Add("Mushrooms");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                listBox1.Items.Add("Pepperoni");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                listBox1.Items.Add("Large Pizza");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            if(radiobutton1.Checked)
            {
                total += 5;
            }
            else if (radioButton2.Checked)
            {
                total += 10;
            }
            if(checkBox1.Checked)
            {
                total += 0.50;
            }
            if (checkBox2.Checked)
            {
                total += 1.00;
            }
            if (checkBox3.Checked)
            {
                total += 0.75;
            }
            if (checkBox4.Checked)
            {
                total += 0.50;
            }
            if (checkBox5.Checked)
            {
                total += 1.50;
            }
            textBox1.Text = Convert.ToString("$" + total);
        }
    }
}
