using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Perm
    {
        private int[] array;
        private int[] used;

        public void GenPerm(int n, int k)
        {
            array = new int[k + 1];
            used = new int[n+1];
            GenPerm(n, k, 0);
        }

        private void GenPerm(int n, int k, int start)
        {
            for(int i=1;i<=n;i++)
                if (used[i] == 0)
                {
                    used[i] = 1;
                    array[start] = i;
                    if (start == k)
                    {
                        for (int j = 0; j <= start; j++)
                            Console.Write(array[j] + " ");
                        Console.WriteLine();
                    }
                    else GenPerm(n, k, start + 1);
                    used[i] = 0;
                }
        }
    }
}
