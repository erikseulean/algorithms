using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class MaximumSubmatrix
    {
        private int start;
        private int tempStart;
        private int end;
        private int tempEnd;
        private int top;
        private int bottom;
        private int maxSum;
        private int tempSum = Int32.MinValue;

        public void GetTemp(int[] array,int n)
        {
            int currentSum = 0;
            int currentStart = 0;
            for (int i = 0; i < n; i++)
            {
                currentSum += array[i];
                if (currentSum < array[i])
                {
                    currentSum = array[i];
                    currentStart = i;
                }
                if (currentSum > tempSum)
                {
                    tempSum = currentSum;
                    tempStart = currentStart;
                    tempEnd = i;
                }
            }
        }

        public void CalculateMax(int[,] matrix,int n)
        {
            int boundary = 0;
            int[] temp = new int[matrix.Length];
            while (boundary != n)
            {
                for (int k = 0; k < n; k++)
                    temp[k] = 0;
                for (int i = boundary; i < n; i++)
                {
                    for (int j = 0; j < n; j++)  
                        temp[j] += matrix[j, i];
                    GetTemp(temp,n);
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        start = boundary;
                        end = i;
                        top = tempStart;
                        bottom = tempEnd;
                    }
                }
                boundary++;
            }
        }

        public void MaxSubMatrix(int[,] matrix)
        {
            for (int i = start; i <= bottom; i++)
            {
                Console.WriteLine();
                for (int j = top; j <= end; j++)
                    Console.Write(matrix[i, j] + " ");
            }
        }
    }
}
