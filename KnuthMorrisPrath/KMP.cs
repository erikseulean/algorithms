using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnuthMorrisPrath
{
    public class KMP
    {
        private int[] T;

        public void CreateT(string word)
        {
            T = new int[word.Length];
            T[0] = 0;
            int k = 0;
            for (int i = 1; i < word.Length; i++)
            {
                while (k != 0 && word[i] != word[k])
                    k = T[k];
                if (word[k] == word[i])
                    k++;
               T[i] = k;
            }
        }

        public int CheckExisting(string word1, string word2)
        {
            if (word1.Length < word2.Length)
                return -1;
            CreateT(word2);
            int k = 0;
            for(int i=0;i<word1.Length;i++)
            {
                while (k > 0 && word1[i] != word2[k])
                    k = T[k-1];
                if (word2[k] == word1[i])
                    k++;
                if (k == word2.Length)
                    return i - k + 1;
            }
            return -1;
        }

        public void PrintT()
        {
            for (int i = 0; i < T.Length; i++)
                Console.Write(T[i] + " ");
            Console.WriteLine();
        }
    }
}
