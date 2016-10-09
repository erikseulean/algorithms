using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class NumberDecompose
    {
        public int Number(int a) {
            List<int> numbers = new List<int>();
            List<int> values = new List<int>();
            while (a != 0)
            {
                numbers.Insert(0, a % 10);
                a = a / 10;
            }

            for (int i = 1; i < numbers.Count; i++)
            {
                for (int k = 0; k < numbers.Count; k++)
                {
                    int nr = 0;
                    int p = k;
                    int j;
                    for (j = 0; j < i; j++)
                    {
                        nr = nr * 10 + numbers[p];
                        if (p < numbers.Count - 1)
                            p++;
                        else break;
                    }
                    if(j >= i-1)
                        values.Add(nr);
                }
            }

            return 0;
        }
    }
}
