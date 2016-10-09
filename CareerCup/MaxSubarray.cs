using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class MaxSubarray
    {
        public int GetMaxArray(int[] array)
        {
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (sum + array[i] > array[i])
                    sum += array[i];
                else sum = array[i];
                if (sum > max)
                    max = sum;
            }

            return max;
        }
    }
}
