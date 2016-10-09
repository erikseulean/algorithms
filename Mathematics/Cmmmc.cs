using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Cmmmc
    {
        private bool CheckIfPrime(int nr)
        {
            for(int i=2;i<=nr/2;i++)
                if (nr%i == 0)
                    return false;
            return true;
        }
        public int GetCmmmc(int a, int b)
        {
            int nr = 1;
            for (int i = 2; i < Math.Max(a, b);i++)
            {
                if (CheckIfPrime(i))
                {
                    if (a%i == 0 && b%i == 0)
                        nr = nr*(int) Math.Pow(i, Math.Max(a/i, b/i));
                    else if (a%i == 0)
                        nr = nr*(int) Math.Pow(i, a/i);
                    else if (b%i == 0)
                        nr = nr*(int) Math.Pow(i, b/i);
                }
            }

            return nr;
        }
    }
}
