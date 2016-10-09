using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class ConsecutiveSum
    {
        public void PrintSums(int n)
        {
            for (int i = 1; i <= n / 2 + 1; i++)
                Find(i, n);
        }

        private void Find(int i, int n)
        {
            int k = i;
            int sum = 0;
            while (k < n)
            {
                sum += k;
                if (sum == n)
                {
                    Console.WriteLine(i + " " + (k - i));
                    return;
                }
                else if (sum > n) return;
                k++;
            }

        }
    }
}