
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MatrixOperations
{
    public static class Matrix
    {
        public static void Rotate90Degrees(ref int[,] matrix, int n)
        {
            int aux;
            int[,] auxMatrix = new int[4,4];
            for(int i=0;i<n;i++)
                for (int j = 0; j < n; j++)
                {
                    auxMatrix[i,j] = matrix[n - j - 1,i];
                }
            matrix = auxMatrix;
        }

        public static void Rotate90DegreesNoExtraData(ref int[,] matrix, int n)
        {
            int aux;
            for (int i = 0; i < n/2; i++)
                for(int j=i; j<n - i - 1;j++)
                {
                    aux = matrix[i, j];
                    matrix[i, j] = matrix[j, n - i - 1];
                    matrix[j, n - i - 1] = matrix[n - i - 1, n - j - 1];
                    matrix[n - i - 1, n - j - 1] = matrix[n - j - 1, i];
                    matrix[n - j - 1, i] = aux;
                }
            
        }

        public static void Set0ToLineAndColumn(ref int[,] matrix, int n, int m)
        {
            List<int> line = new List<int>();
            List<int> row = new List<int>();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (matrix[i, j] == 0)
                    {
                        line.Add(i);
                        row.Add(j);
                    }
            foreach(var item in line)
            {
                for (int j = 0; j < m; j++)
                    matrix[item, j] = 0;
            }
            foreach(var item in row)
            {
                for (int i = 0; i < n; i++)
                    matrix[i, item] = 0;
            }
        }

        public static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j=0;j<n;j++)
                    Console.Write(matrix[i,j] + " ");
                Console.WriteLine();
            }
        }
    }
}
