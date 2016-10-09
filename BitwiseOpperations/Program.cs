using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOpperations
{
    class Program
    {
        public static int DecrementNumber(int nr)
        {
            if (nr == 0) return 0;
            int iterator = nr;
            int zeroPos = 0, onePos = 0;
            int nrOnes =0;
            bool foundZero = false, foundOne = false;
            while (foundOne != true)
            {
                if ((iterator & 1) == 0)
                    foundZero = true;
                if (foundZero && (iterator & 1) == 1)
                {
                    zeroPos = onePos - 1;
                    foundOne = true;
                }
                else if (!foundZero && (iterator & 1) == 1)
                    nrOnes++;
                iterator = iterator >> 1;
                onePos++;
            }
            onePos--;
            int zeroMask = 1 << zeroPos;
            int oneMask = ~(1 << onePos);
            int mask = nr & ~(~0 << zeroPos);
            mask = mask << (zeroPos - nrOnes);
            nr = nr & (~0 << zeroPos);
            nr = (nr & oneMask) | zeroMask;
            return nr | mask;
        }

        public static int IncrementNumber(int nr)
        {
            int intNr = nr;
            int fZero = 0;
            int fOne = 0;
            if (nr == Int32.MaxValue)
                return -1;
            if (nr == 0) return 0;
            bool foundZero = false;
            bool foundOne = false;
            while (foundZero != true)
            {
                if ((intNr & 1) == 1)
                    foundOne = true;
                if (foundOne && (intNr & 1) == 0)
                {
                    foundZero = true;
                    fOne = fZero - 1;
                }
                intNr = intNr >> 1;
                fZero++;
            }
            fZero--;
	
            //turn 0 to 1 and 1 to zero
            int zeroMask = (1 << fZero);
            int oneMask = ~(1 << fOne);
            int realMask = ~(~0 << fOne);
            realMask = nr & realMask; 
            while (realMask != 0 && (realMask & 1) != 1)
                realMask = realMask >> 1;
            nr = (nr & oneMask) | zeroMask;
            nr = nr & (~0 << fOne);
            nr = nr | realMask;
            return nr;
        }

        public static int swapBits(int nr)
        {
            int mask;
            int odd;
            int even;
            int intermediary = nr;
            int count = 0;
            while (intermediary != 0)
            {
                count++;
                intermediary = intermediary >> 1;
            }
            for (int i = 0; i < count; i++)
            {
                odd = (nr >> i * 2) & 1;
                even = (nr >> i * 2 + 1) & 1;
                nr = nr & ~(~(~0 << 2)<<2*i);
                mask = ((odd << 1) + even) << 2 * i;
                nr = nr | mask;
            }
            return nr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(swapBits(128));
            Console.ReadLine();
        }
    }
}
