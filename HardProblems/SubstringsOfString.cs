using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class SubstringsOfString
    {
        private HashSet<string> words;

        public SubstringsOfString()
        {
            words = new HashSet<string>();
        }

        public void PopulateSet(string word)
        {
            for(int i=1;i<word.Length;i++)
            {
                string first = word.Substring(0, i);
                string second = word.Substring(i, word.Length - i);
                if (!words.Contains(first))
                    words.Add(first);
                if (!words.Contains(second))
                    words.Add(second);
            }
        }

        public bool IsPartialMatch(string word, string subword)
        {
            if (words.Count == 0)
                PopulateSet(word);
            if (words.Contains(subword)) return true;
            return false;
        }
    }
}
