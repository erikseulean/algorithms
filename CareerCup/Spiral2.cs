using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class Spiral2
    {
        public void Print(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                    Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }

        public void CreateSpiral(int n)
        {
            int[,] matrix = new int[n, n];
            int k = 1;
            int counter = 0;
            while (k < n*n)
            {
                for(int i=counter;i<n-counter;i++)
                {
                    matrix[counter, i] = k;
                    k++;
                }

                for(int i=counter+1;i<n-counter;i++)
                {
                    matrix[i,n - counter-1] = k;
                    k++;
                }

                for(int i=n-counter-2;i>=counter;i--)
                {
                    matrix[n - counter-1,i] = k;
                    k++;
                }

                for (int i = n - counter - 2; i >= counter + 1;i--)
                {
                    matrix[i,counter] = k;
                    k++;
                }
                counter++;
            }

            Print(matrix,n);
        }
    }
}
