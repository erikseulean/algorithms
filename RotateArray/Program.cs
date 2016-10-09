using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Rotate(array, 4);

        }

        public static int GetCycles(int n, int k)
        {
            while (true)
            {
                if (n == k) return n;
                if (n > k) n = n - k;
                if (n < k) k = k - n;
            }
        }

        public static void Rotate(int[] a, int k)
        {
            int cycles = GetCycles(a.Length, k);
            int steps = a.Length / cycles;
            int n = a.Length;
            for (int start = 0; start < cycles; start++)
            {
                int prev = a[start];
                int st = start;
                for (int i = 0; i <= steps; i++)
                {
                    int next = a[(st + k) % n];
                    a[(st + k) % n] = prev;
                    st = (st + k) % n;
                    prev = next;
                }
            }
        }
    }
}
