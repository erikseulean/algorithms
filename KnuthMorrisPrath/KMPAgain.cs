using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnuthMorrisPrath
{
    public class KMPAgain
    {
        private int[] array;

        public void CreateT(string s)
        {
            int i = 0;
            array = new int[s.Length];
            for (int j = 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    array[j] = array[j-1] + 1;
                    i++;
                }
                else
                {
                    while (i != 0 && s[i] != s[j])
                    {
                        i--;
                        if (s[i] == s[j]) break;
                        i = array[i];
                    }
                    if (s[i] == s[j])
                        array[j] = i + 1;
                    else array[j] = 0;
                }
            }
        }

        public int FindMatch(string text, string word)
        {
            CreateT(word);
            int k = 0;
            for (int i = 0; i < text.Length; i++)
            {
                while (k != 0 && word[k] != text[i])
                    k = array[k];
                //if (k > 0) k--;
                if (word[k] == text[i]) k++;
                if (k == word.Length) return i - k - 1;
            }

            return -1;
        }

        public void PrintT()
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.ReadLine();
        }
    }
}
