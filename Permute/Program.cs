using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permute
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3,2,0,1,4 };
            int[] perm = new int[] { 1, 2, 3, 4, 0 };
            PermuteAgain(a);
        }

        public static void Permutation(int[] a, int[] perm)
        {
            for (int i = 0; i < a.Length; i++)
                if (perm[i] >= 0)
                {
                    int id = i;
                    int temp = a[i];
                    while (perm[id] > 0)
                    {
                        int next = perm[id];
                        a[id] = a[next];
                        perm[id] -= a.Length;
                        id = next;
                        if (perm[id] == i)
                        {
                            a[id] = temp;
                            break;
                        }
                        //if (id == i) break;
                    }
                }
        }

        public static void PermuteAgain(int[] a)
        {
            int i = 0;
            int val = i;
            int pos = a[i];
            while (pos != i)
            {
                int posUrm = a[pos];
                int valUrm = pos;
                a[pos] = val;
                pos = posUrm;
                val = valUrm;
            }
        }
    }
}
