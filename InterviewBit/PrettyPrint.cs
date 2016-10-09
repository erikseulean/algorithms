using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class PrettyPrint
    {
        public void Print(int n)
        {
            int[,] matrix = new int[2 * n - 1, 2 * n - 1];
            int k = 0;
            while (k != n)
            {
                for (int i = k; i < 2 * n - k - 1; i++)
                {
                    matrix[i, k] = n - k;
                    matrix[k, i] = n - k;
                    matrix[2 * n - k - 2, i] = n - k;
                    matrix[i, 2 * n - k - 2] = n - k;
                }
                k++;
            }

            PrintMatrix(matrix, n);
        }

        public void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < 2*n-1; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 2*n-1; j++)
                    Console.Write(matrix[i, j] + " ");
            }
        }
    }
}
