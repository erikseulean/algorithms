using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerateProblems
{
    public class FactorialTrailingZeros
    {
        public static int TrailingZeros(int n)
        {
            int twos = 0;
            int fives = 0;
            for(int i=5;i<=n;i=i+5)
                if (i%5 == 0)
                    fives++;
                
            return fives;
        }
    }
}
