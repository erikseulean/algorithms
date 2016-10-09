using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort
    {
        public void Sort(ref int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left)/2;
                Sort(ref array,left,middle);
                Sort(ref array,middle + 1,right);
                Merge(ref array, left, right);
            }   
        }

        private void Merge(ref int[] array, int left, int right)
        {
            int middle = (left + right)/2;
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int i = 0;
            int j = 0;

            int[] L1 = new int[n1];
            int[] R1 = new int[n2];

            for (i = 0; i < n1; i++)
                L1[i] = array[left + i];
            for (j = 0; j < n2; j++)
            {
                R1[j] = array[middle + j + 1];
            }
            i = 0;
            j = 0;
            for (int k = left; k <= right; k++)
            {
                if (i == L1.Length || (j != R1.Length && L1[i] > R1[j]))
                {
                    array[k] = R1[j];
                    j++;
                }
                else
                {
                    array[k] = L1[i];
                    i++;
                }
            }
        }
    }
}
