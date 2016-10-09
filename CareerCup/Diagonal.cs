using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class Diagonal
    {
        public void PrintDiagonals(int[,] matrix, int n)
        {
            int small = 0;
            int big = 0;
            int k = 0;
            int boundary = 0;
            while (k < n + n)
            {
                if (k > n - 1)
                    boundary = n;
                else boundary = k + 1;
                for (int i = 0; i < boundary; i++)
                    for (int j = 0; j < boundary; j++)
                        if(i+j == k)
                            Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
                k++;
            }
        }
    }
}
