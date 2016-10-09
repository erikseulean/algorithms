using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Combinations comb = new Combinations();
            comb.Generate(new int[] { 1, 2, 3, 4, 5 }, 3);
            Console.ReadLine();
        }
    }
}
