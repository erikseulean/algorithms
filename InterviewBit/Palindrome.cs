using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class Palindrome
    {
        public int IsPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s))
                return 0;
            int i = 0;
            int j = s.Length -1;
            while (i < j)
            {
                while (i < j && !Char.IsLetterOrDigit(s[i])) i++;
                while (j > i && !Char.IsLetterOrDigit(s[j])) j--;
                if (char.ToLower(s[i]) != char.ToLower(s[j])) 
                    return 0;
                i++;
                j--;
            }
            return 1;
        }
    }
}
