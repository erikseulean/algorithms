using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 19, 71, 4, 101, 1, 9, 3, 2, 4, 5, 1, 2 };
            RankSort sort = new RankSort();
            Console.WriteLine(sort.KthElement(array, 0, array.Length - 1, 2));
            Console.ReadLine();
        }
    }
}
