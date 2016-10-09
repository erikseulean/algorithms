using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicographicPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Permute perm = new Permute();
            perm.PrintPermutations(new int[] { 1, 2, 3 });
            Console.ReadLine();
        }
    }
}
