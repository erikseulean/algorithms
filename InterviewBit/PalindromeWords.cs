using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class PalindromeWords
    {
        public List<string> getPalindrome(string s)
        {
            //s = s.ToLower();
            int count = 0;
            List<string> words = new List<string>();
            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
            for (int i = s.Length - 1; i >= 0; i--)
                if (dict.ContainsKey(s[i]))
                    dict[s[i]].Add(i);
                else
                    dict.Add(s[i], new List<int>() { i });
            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]].Count == 1)
                {
                    count++;
                    words.Add(s[i].ToString());
                }
                else
                {
                    bool done = false;
                    for (int j = 0; j < dict[s[i]].Count; j++)
                    {
                        if (dict[s[i]][j] > i)
                        {
                            int index = dict[s[i]][j] - 1;
                            int k = i + 1;
                            if(index - k == 1)
                                if (s[index] == s[k])
                                {
                                    count++;
                                    words.Add(s.Substring(i, dict[s[i]][j] - i + 1));
                                    i = dict[s[i]][j];
                                    done = true;
                                    break;
                                }
                            while (s[k] == s[index] && k != index && k - index != 1)
                            {
                                k++;
                                index--;
                            }
                            if (k == index || k - index == 1 && index != 0)
                            {
                                count++;
                                words.Add(s.Substring(i, dict[s[i]][j] - i + 1));
                                i = dict[s[i]][j];
                                done = true;
                                break;
                            }
                        }
                    }
                    if (!done)
                    {
                        count++;
                        words.Add(s[i].ToString());
                    }
                }
            }
            return words;
        }
    }
}
