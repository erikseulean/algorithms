using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class Words
    {
        private List<string> checkedWords = new List<string>();
        public void CheckPath(string input, string final, List<string> words, List<string> allWords,int pos)
        {
            if (!checkedWords.Contains(input))
                checkedWords.Add(input);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != final[i])
                {
                    StringBuilder sb = new StringBuilder(input);
                    sb[i] = final[i];
                    string newWord = sb.ToString(); ;
                    if (newWord.Equals(final))
                    {
                        Print(words);
                        return;
                    }
                    else if (allWords.Contains(newWord) && !checkedWords.Contains(newWord))
                    {
                        words.Add(newWord);
                        CheckPath(newWord, final, words, allWords, 0);
                        return;
                    }
                }
            }
            if (words.Count > 1)
                words.Remove(words[words.Count - 1]);
            for (int j = 0; j < input.Length;j++ )
                for (char i = 'A'; i <= 'Z'; i++)
                {
                    StringBuilder sb = new StringBuilder(input);
                    sb[j] = i;
                    string newWord = sb.ToString(); ;
                    if (newWord.Equals(final))
                    {
                        Print(words);
                        return;
                    }
                    else if (!checkedWords.Contains(newWord) && input != newWord && allWords.Contains(newWord))
                    {
                        words.Add(newWord);
                        CheckPath(newWord, final, words, allWords, 0);
                        return;
                    }
                }
        }

        public void Print(List<string> words)
        {
            foreach (var item in words)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
