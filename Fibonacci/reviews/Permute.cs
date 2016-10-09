using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.reviews
{
    public class Permute
    {
        private char[] array;
        public Permute()
        {
            array = new char[1000];
        }
        public void Permutations(string s, int poz)
        {
            for (int i = 0; i < s.Length; i++)
            {
                array[poz] = s[i];
                if (Valid(poz))
                {
                    if (poz == s.Length - 1)
                        Print(poz);
                    else Permutations(s, poz + 1);
                }

            }
        }

        public bool Valid(int poz)
        {
            for (int i = 0; i < poz; i++)
                if (array[i] == array[poz])
                    return false;
            return true;
        }

        public void Print(int poz)
        {
            for (int i = 0; i <= poz; i++)
                Console.Write(array[i]);
            Console.WriteLine();
        }
    }
}
