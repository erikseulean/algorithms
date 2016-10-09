using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSmaller
{
    
    public class MergeSort
    {
        private int[] sol;
        private int[] array;
        private Dictionary<int, int> d;
        public MergeSort(int[] array)
        {
            this.array = array;
            sol = new int[array.Length];
            d = new Dictionary<int,int>();
            for (int i = 0; i < array.Length; i++)
                d.Add(array[i], i);

        }

        public int[] Sort(int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                Sort(left, mid);
                Sort(mid + 1, right);
                Merge(left, mid, right);
            }
            return sol;
        }

        public void Merge(int left, int mid, int right)
        {
            int lenL = mid - left + 1;
            int lenR = right - mid;
            int[] l = new int[lenL];
            int[] r = new int[lenR];
            int i;
            for (i = 0; i < lenL; i++)
                l[i] = array[i + left];
            for (i = 0; i < lenR; i++)
                r[i] = array[i + mid + 1];
            i = 0;
            int j = 0;
            int count = 0;
            for (int k = left; k <= right; k++)
            {
                if (i > lenL-1 || (j < lenR && l[i] > r[j]))
                {
                    count++;
                    array[k] = r[j];
                    j++;
                }
                else
                {
                    sol[d[l[i]]] += count;
                    array[k] = l[i];
                    i++;
                }
            }
        }
    }
}
