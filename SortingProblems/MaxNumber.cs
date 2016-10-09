using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    public class MaxNumber
    {
        public bool Compare(string s1, string s2)
        {
            if (Convert.ToInt32(s1 + s2) > Convert.ToInt32(s2 + s1)) return true;
            return false;
        }

        public void Quicksort(int[] array, int left, int right)
        {
            int mid = left + (right - left) / 2;
            int pivot = array[mid];
            int i = left;
            int j = right;
            int aux;
            while (i <= j)
            {
                while (Compare(array[i].ToString(), pivot.ToString())) i++;
                while (Compare(pivot.ToString(), array[j].ToString())) j--;
                if (i <= j)
                {
                    aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                    i++;
                    j--;
                }
            }

            if (j > left) Quicksort(array, left, j);
            if (i < right) Quicksort(array, i, right);
        }
    }
}
