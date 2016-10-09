using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    public class ReversedBinary
    {
        public int BinarySearch(int[] array, int nr, int left, int right)
        {
            if (left > right)
                return -1;
            int mid = left + (right - left)/2;
            if (array[mid] == nr) return mid;
            if ((nr > array[0] && nr < array[mid]) || (nr < array[0] && nr > array[mid]))
                return BinarySearch(array, nr, mid + 1, right);
            return BinarySearch(array, nr, left, mid-1);
        }
    }
}
