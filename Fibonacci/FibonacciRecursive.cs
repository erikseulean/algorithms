using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciRecursive
    {
        public static int GetNth(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return GetNth(n - 1) + GetNth(n - 2);
        }
    }
}
