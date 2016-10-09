using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerateProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumSum sum = new MaximumSum();
            sum.MaxSum(new[] {-2,-3,4,-1,-2,1,5,-3});
            Console.ReadLine();
        }
    }
}
