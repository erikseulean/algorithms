using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class Wave
    {
        public void Waveeee(int[] array)
        {
            int k = 0;
            int small, nextSmall, big;
            int step = 1;
            small = array[0];
            nextSmall = array[1];
            big = array[array.Length - 1];

            for(k=0;k<array.Length/2;k=k+2)
            {
                array[k] = big;
                array[k + 1] = small;

                small = nextSmall;
                nextSmall = array[k + 2];
                step++;
                big = array[array.Length - step];
            }
        }
    }
}
