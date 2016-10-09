using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Fibonacci
{
    public class Permutations
    {
        private char[] intermediary = new char[1000];

        public void Permute(char[] word)
        {
            Permute(0,word);
        }
        private void Permute(int k, char[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                intermediary[k] = word[i];
                if (IsValid(k))
                {
                    if(k == word.Length - 1)
                        Print(k);
                    Permute(k+1,word);
                }
            }
        }

        private void Print(int k)
        {
            for(int i=0;i<=k;i++)
                Console.Write(intermediary[i] + " ");
            Console.WriteLine();
        }

        private bool IsValid(int k)
        {
            for(int i=0;i<k;i++)
                if (intermediary[i] == intermediary[k])
                    return false;
            return true;
        }
    }
}
