using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    public class LIS
    {
        public int Compute(int[] array)
        {
            int[] tails = new int[array.Length];
            int len = 1;
            tails[0] = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < tails[0])
                    tails[0] = array[i];
                else if(array[i] > tails[len-1])
                {
                    tails[len] = array[i];
                    len++;
                }
                else
                {
                    int index = Find(tails, 0, len - 1, array[i]);
                    tails[index] = array[i];
                }
            }
            return len;
        }

        public int Find(int[] tail, int left, int right,int value)
        {
            while (right - left > 1)
            {
                int mid = left + (right - left) / 2;
                if (tail[mid] < value)
                    left = mid;
                else right = mid;
            }

            return right;
        }
    }
}
