using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingProblems.PeopleProblem;

namespace SortingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {2,1,101,187,198};
            MaxNumber number = new MaxNumber();
            number.Quicksort(array, 0, array.Length-1);
            
            Console.ReadLine();
        }
    }
}
