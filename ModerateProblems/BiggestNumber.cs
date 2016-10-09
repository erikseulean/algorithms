using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerateProblems
{
    public class BiggestNumber
    {
        public static int Max(int a, int b)
        {
            int dif = Math.Abs(a - b);
            int sum = a + b;
            return (dif + sum)/2;

        }
    }
}
