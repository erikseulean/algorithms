using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class LetterCombination
    {
        private List<string> solutions = new List<string>();
        private Dictionary<char, string> dict = new Dictionary<char, string>();
        public LetterCombination()
        {
            dict.Add('0', "0");
            dict.Add('1', "1");
            dict.Add('2', "abc");
            dict.Add('3', "def");
            dict.Add('4', "ghi");
            dict.Add('5', "jkl");
            dict.Add('6', "mnp");
            dict.Add('7', "qrs");
            dict.Add('8', "tuv");
            dict.Add('9', "wxyz");
        }

        public void Back(StringBuilder s, int pos, string initial)
        {
            if (pos == initial.Length)
            {
                solutions.Add(s.ToString());
                return;
            }
            string letters = dict[initial[pos]];
            for (int i = 0; i < letters.Length; i++)
            {
                s.Append(letters[i]);
                Back(s, pos + 1, initial);
                s.Length--;
            }
        }

        
    }
}
