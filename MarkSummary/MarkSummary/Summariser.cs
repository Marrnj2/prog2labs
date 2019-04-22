using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkSummary
{
    class Summariser
    {
        public Summariser()
        {

        }
        public int FindMinimum(Data data)
        {

        }
        public int FindMaximum(Data data)
        {

        }
        public int CalculateAverage(Data data)
        {
            int total = 0;
            int temp;
            for (int i = 0; i < 10; i++)
            {
                temp = data.Scores1[i];
                total += temp;
            }
            
        }
    }
}
