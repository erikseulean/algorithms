using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class SequenceGenerator
    {
        public string Generate(int n)
        {
            if (n == 1) return "1";
            if (n == 2) return "11";
            StringBuilder past = new StringBuilder("11");
            StringBuilder current = new StringBuilder();
            int k = 2;
            while (k != n)
            {
                int i = 0;
                int counter = 1;
                while (i < past.Length)
                {
                    while (i + 1 != past.Length && past[i] == past[i + 1])
                    {
                        counter++;
                        i++;
                    }

                    current.Append(counter.ToString() + past[i].ToString());
                    i++;
                    counter = 1;
                }
                past = current;
                current = new StringBuilder();
                k++;
            }
            return past.ToString(); ;
        }
    }
}
