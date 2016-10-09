using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizationOfMaxDifference
{
    class Generalization
    {
        int maxDif = 0;

        public int DivideAndConquer(int left, int right, int[] array)
        {
            if (left >= right) return 0;

            int mid = left + (right - left) / 2;
            maxDif = Math.Max(maxDif,Math.Max(DivideAndConquer(left, mid - 1, array), DivideAndConquer(mid + 1, right, array)));

            int mini = left;
            int min = Int32.MaxValue;
            int maxi = mid+1;
            int max = Int32.MinValue;
            for(int i=left;i<=mid;i++)
                if (min > array[i]) {
                    min = array[i];
                    mini = i;
                }
            for (int i = mid+1; i <= right; i++)
                if (max < array[i]) {
                    max = array[i];
                    maxi = i;
                }

            return max - min + DivideAndConquer(maxi+1,right,array);
        }
    }
}
