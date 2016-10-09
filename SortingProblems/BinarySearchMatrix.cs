using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    public class BinarySearchMatrix
    {
        private int n;
        private int m;
        private int[,] matrix;
        public BinarySearchMatrix(int n, int m,int[,] matrix)
        {
            this.n = n;
            this.m = m;
            this.matrix = matrix;
        }

        public void Search(int nr)
        {
            int line = FindLine(nr, 0, n - 1);
            if (line == -1)
                Console.WriteLine("Not in matrix");
            else
            {
                int row = FindRow(nr, line, 0, m - 1);
                if(row == -1)
                    Console.WriteLine("not in matrix");
                else Console.WriteLine(line + " " + row);
            }
        }

        private int FindLine(int nr, int left, int right)
        {
            if (left > right)
                return -1;
            int mid = left + (right - left)/2;
            if (matrix[mid, 0] <= nr && matrix[mid, m - 1] >= nr)
                return mid;
            else if (matrix[mid, 0] > nr)
                return FindLine(nr, left, mid-1);
            return FindLine(nr, mid+1, right);
        }

        private int FindRow(int nr, int line, int left, int right)
        {
            if (left > right)
                return -1;
            int mid = left + (right - left)/2;
            if (nr == matrix[line, mid])
                return mid;
            else if (nr > matrix[line, mid])
                return FindRow(nr, line, mid + 1, right);
            return FindRow(nr, line, left, mid - 1);
        }
    }
}
