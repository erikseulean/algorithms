using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class PascalTriangle
    {
        public void PrintTriangle(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n / 2; i++)
            {
                array[i] = i + 1;
                array[n - i - 1] = i + 1;
            }
            if (n % 2 != 0)
                array[n / 2] = array[n / 2 - 1] + 1;
            for (int i = 0; i < n; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        public void OnlyPrintTriangle(int n)
        {
            int i;
            if (n % 2 == 0)
            {
                for (i = 0; i < n / 2; i++)
                    Console.Write((i + 1) + " ");
                Console.Write(i + " " );
                i--;
                for (int j = i; j > 0; j--)
                    Console.Write(j + " ");
            }
            else
            {
                for (i = 1; i <= n / 2 + 1; i++)
                    Console.Write(i + " ");
                i = i - 2;
                for (int j = i; j > 0; j--)
                    Console.Write(j + " ");
            }
        }

        public void PrintPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
                PrintTriangle(i);
        }
    }
}
