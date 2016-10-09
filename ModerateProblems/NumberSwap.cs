using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerateProblems
{
    public class NumberSwap
    {
        public static void SwapAwithB(ref int a, ref int b)
        {
            //a = a - b;
            //b = a + b;
            //a = b - a;

            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
        }
    }
}
