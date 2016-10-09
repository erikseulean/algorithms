using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class Subsequence
    {
        public void PrintSequences(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                    if (s1[i] == s2[j])
                    {
                        int k = j + 1;
                        int p = i + 1;
                        while (p != s1.Length && k != s2.Length && s1[p] == s2[k])
                        {
                            p++;
                            k++;
                        }
                        if (p > i + 1)
                        {
                            Console.WriteLine(s1.Substring(i, p - i));
                            if(p<s1.Length)
                                i = p;
                        }
                    }
            }

        }
    }
}
