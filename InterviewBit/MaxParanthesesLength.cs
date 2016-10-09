using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class MaxLength
    {
        public int Start { get; set; }
        public int End { get; set; }
    }
    public class MaxParanthesesLength
    {
        public int longestValidParantheses(string s)
        {
            if (s.Length < 2) return 0;
            Stack<int> stack = new Stack<int>();

            int max = -1;
            int maxStart = -1;
            int maxEnd = -1;
            List<int> maxes = new List<int>();
            List<MaxLength> maxLength = new List<MaxLength>();
            for (int i = 0; i < s.Length; i++)
                if (s[i] == '(')
                    stack.Push(i);
                else if(stack.Count > 0 && s[i] == ')')
                {
                    bool nothing = true;
                    int localStart = stack.Pop();
                    foreach (var item in maxLength)
                        if (localStart - item.End == 1)
                        {
                            item.End = i;
                            nothing = false;
                        }
                        if(nothing)
                        {
                            maxLength.Add(new MaxLength()
                            {
                                Start = localStart,
                                End = i
                            });
                        }
                }
            max = 0;
            foreach (var item in maxLength)
                max = Math.Max(max, item.End - item.Start);
            
            return max+1;
        }
    }
}
