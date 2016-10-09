using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {2,1,101,187,198};
            MergeSort sort = new MergeSort();
            sort.Sort(ref array,0,array.Length - 1);

            foreach (var item in array)
                Console.Write(item + " ");
            Console.ReadLine();

        }
    }
}
