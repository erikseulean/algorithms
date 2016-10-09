using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerateProblems
{
    public class MaximumSum
    {

        public void MaxSum(int[] array)
        {
            if (array == null || array.Length == 0)
                return;
            int currentSum = 0;
            int maxSum = Int32.MinValue;
            int start = 0;
            int end = 0;
            int currentStart = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    currentSum += array[i];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
                else if (currentSum + array[i] < array[i])
                {
                    currentSum = array[i];
                    currentStart = i;
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        start = i;
                        end = i;
                    }
                }
                else
                {
                    currentSum += array[i];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        end = i;
                        start = currentStart;
                    }
                }
            }

            for (int i = start; i <= end; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine("\n" + maxSum);
        }
    }
}
