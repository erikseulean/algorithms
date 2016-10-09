using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Fibonacci
{
    public class FillColor
    {
        private int[,] matrix;
        private int n;
        private int m;

        public FillColor(int n, int m)
        {
            this.n = n;
            this.m = m;
            matrix = new int[,]
            {
                {0, 0, 0, 1, 0, 0},
                {0, 0, 1, 0, 0, 0},
                {0, 0, 1, 0, 0, 0},
                {0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1, 0},
                {0, 0, 0, 1, 0, 0}
            };
        }

        public void Fill()
        {
            Fill(4,1);
            PrintMatrix();
        }

        public void Fill(int x, int y)
        {
               if(x < 0 || y < 0 || x > m || y > n )
                    return;
               if (matrix[x, y] == 0)
                {
                    matrix[x, y] = 2;
                    if(y - 1 >= 0)
                        Fill(x, y - 1);
                    if(y + 1 < n)
                        Fill(x, y + 1);
                    if(x - 1 >= 0)
                        Fill(x - 1, y);
                   if(x + 1 < m) 
                   Fill(x + 1, y);
                }
            PrintMatrix();
            Console.WriteLine();
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                    Console.Write(matrix[i,j] + " ");
            }
        }
    }
}