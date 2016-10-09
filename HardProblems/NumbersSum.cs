using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class NumbersSum
    {
        public static int Sum(int x, int y)
        {
            if (x == 0)
                return y;
            if (y == 0)
                return x;
            int c = 0;
            while (y != 0)
            {
                c = x & y;
                x = x ^ y;
                y = c << 1;
            }

            return x;
        }
    }
}
