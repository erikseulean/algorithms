using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Queens
    {
        private int[] solutions;
        private int n;
        public Queens(int n)
        {
            solutions = new int[n];
            this.n = n;
        }

        public void GetQueensSolution()
        {
            GetQueensSolution(0);
        }

        private void GetQueensSolution(int k)
        {
            for (int i = 0; i < n; i++)
            {
                solutions[k] = i;
                if (Valid(k))
                {
                    if (k == n - 1)
                        Print(k);
                    else GetQueensSolution(k + 1);
                }
            }
        }

        private void Print(int k)
        {
            for(int i=0;i<=k;i++)
                Console.Write(solutions[i] + " ");
            Console.WriteLine();
        }

        private bool Valid(int k)
        {
            for (int i = 0; i < k; i++)
            {
                if(solutions[i] == solutions[k]) return false;
                if (Math.Abs(solutions[i] - solutions[k]) == Math.Abs(i - k)) return false;
            }
            return true;
        }
    }
}
