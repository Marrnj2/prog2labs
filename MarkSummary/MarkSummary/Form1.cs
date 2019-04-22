using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkSummary
{
    public partial class Form1 : Form
    {
        private Random random;
        private Data data1;
        private Data data2;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            data1 = new Data(random, listBox1);
            data2 = new Data(random, listBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data1.ClearList();
            data2.ClearList();
            data1.CreateScore();

            foreach (int result in data1.Scores1)
            {
                listBox1.Items.Add(result);
            }
            data2.CreateScore();
            foreach (int result in data2.Scores1)
            {
                listBox2.Items.Add(result);
            }
        }
    }
}
