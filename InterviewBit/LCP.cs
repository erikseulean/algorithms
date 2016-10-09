using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class LCP
    {
        public string FindLCP(string s1, string s2)
        {
            int length = s1.Length > s2.Length ? s2.Length : s1.Length;
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i != s1.Length && s1[i] == s2[i])
            {
                sb.Append(s1[i]);
                i++;
            }
            return sb.ToString();
        }

        public string FindAll(List<string> words)
        {
            string LCP = FindLCP(words[0], words[1]);
            int LCPLength = LCP.Length;
            for (int i = 2; i < words.Count; i++)
            {
                for (int j = 0; j < words[i].Length && j < LCPLength; j++)
                {
                    if (words[i][j] != LCP[j])
                    {
                        LCPLength = j;
                        continue;
                    }
                }
            }

            if (LCPLength == 0) return String.Empty;
            else return LCP.Substring(0, LCPLength);
        }
    }
}
