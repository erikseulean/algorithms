using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class ComposedWords
    {
        private HashSet<string> words;

        public ComposedWords()
        {
            words = new HashSet<string>();
        }

        public void SaveWords(string[] listOfWords)
        {
            foreach (var item in listOfWords)
                if (!words.Contains(item))
                    words.Add(item);
        }

        public string LongestWord(string[] list)
        {
            if (list.Length == 0)
                return string.Empty;
            if (words.Count == 0)
                SaveWords(list);
            list = list.OrderByDescending(s => s.Length).ToArray();
            for (int i = 0; i < list.Length; i++)
            {
                string word = list[i];
                for (int j = list[list.Length -1].Length; j < word.Length; j++)
                {
                    string first = word.Substring(0, j);
                    string second = word.Substring(j, word.Length - j);
                    if (words.Contains(first) && words.Contains(second))
                        return word;
                }
            }
            return String.Empty;
        }
    }
}
