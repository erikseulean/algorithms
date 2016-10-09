using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class Power
    {
        public bool CheckPower(int nr)
        {
            for(int i=2;i<=nr/2;i++)
            {
                int x = nr;
                while (x != 1 && x % i == 0)
                {
                    x = x / i;
                }
                if (x == 1)
                    return true;
            }
            return false;
        }
    }
}
