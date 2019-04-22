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
    class Data
    {
        private const int NSCORES = 10;
        private Random random;
        private List<int> Scores;
        private ListBox listBox;
        


        public Data(Random random, ListBox listBox)
        {
            this.listBox = listBox;
            this.random = random;
            Scores = new List<int>();
           
        }

        public List<int> Scores1 { get => Scores; set => Scores = value; }

        public void ClearList()
        {
            listBox.Items.Clear();
        }

        public void CreateScore()
        {
            Scores.Clear();
            for (int i = 0; i < NSCORES; i++)
            {
                Scores.Add(random.Next(0, 100));
            }
        }
    }
}
