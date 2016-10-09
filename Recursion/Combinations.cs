using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Combinations
    {
        private int[] used;
        private int[] sol;

        public void Generate(int[] array, int k)
        {
            used = new int[array.Length];
            sol = new int[array.Length];
            Gen(0, k, array);
        }

        public void Gen(int start, int k, int[] array)
        {
            if (start == k)
            {
                for (int i = 0; i < k; i++)
                    Console.Write(sol[i] + " ");
                Console.WriteLine();
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (used[i] == 0 && (start == 0 || array[i] > sol[start-1]))
                {
                    used[i] = 1;
                    sol[start] = array[i];
                    Gen(start + 1, k, array);
                    used[i] = 0;
                }
            }
        }
    }
}
