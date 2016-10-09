using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSmaller
{
    class Program
    {
        //given an array of integers create another array that contains for each position
        //the number of values smaller than the value on the right side of the position of the original array
        static void Main(string[] args)
        {
            MergeSort merge = new MergeSort(new int[] { 5, 7, 3, 2, 1, 4, 8, 9, 6, 10 });
            int[] sol = merge.Sort(0, 9);
        }
    }
}
