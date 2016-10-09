using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class Median
    {
        private LinkedList<int> list;
        private double median;
        private int used = 0;
        private int globalCount = 0;
        public Median()
        {
            list = new LinkedList<int>();
        }

        public double GetMedian()
        {
            return median;
        }

        public void AddNumber(int nr)
        {
            list.AddLast(nr);
            globalCount++;
            if (globalCount % 2 == 1)
            {
                median = Convert.ToDouble(list.First.Value);
                used++;
            }
            else
            {
                median = Convert.ToDouble(list.First.Value + list.First.Next.Value) / 2;
                used++;
            }
            if (used > 1)
            {
                used = 0;
                list.RemoveFirst();
            }
        }
    }
}
