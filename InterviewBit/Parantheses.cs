using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class Parantheses
    {
        private List<int> sum = new List<int>();
        public void Back(int n)
        {
            for (int i = n; i > 0; i--)
            {
                sum.Add(i);
                int valid = Valid();
                if (valid < 2 * n)
                    Back(n);
                else if (valid == 2 * n)
                    TryPrint();
                sum.RemoveAt(sum.Count - 1);
            }
        }

        private void TryPrint()
        {
            if (sum.Count % 2 != 0)
                return;
            int open = 0;
            int close = 0;
            for (int i = 0; i < sum.Count; i++)
            {
                if (i % 2 == 0) open += sum[i];
                else close += sum[i];
                if (close > open)
                    return;
            }
            if (open == close)
            {
                for (int i = 0; i < sum.Count; i++)
                    for (int j = 0; j < sum[i]; j++)
                        if (i % 2 == 0) Console.Write("(");
                        else Console.Write(")");
                Console.WriteLine();
            }
        }

        public int Valid()
        {
            int tsum = 0;
            foreach (var item in sum)
                tsum += item;
            return tsum;
        }
    }
}
