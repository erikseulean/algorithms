using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class PalindromeWord
    {
        List<string> values = new List<string>();
        public void Back(StringBuilder sb, string input, int start)
        {
            if (sb.Length >= input.Length)
                return;
            for (int i = start+1; i < input.Length; i++)
            {
                sb.Append(input[i]);
                if (Valid(sb,input.Length))
                {
                    values.Add(sb.ToString());
                }
                Back(sb, input, start + 1);
                sb.Length--;
            }
        }

        private bool Valid(StringBuilder sb, int length)
        {
            if (sb.Length >= length)
                return false;
            for (int i = 0; i < sb.Length; i++)
                if (sb[i] != sb[sb.Length - i - 1])
                    return false;
            return true;
        }
    }
}
