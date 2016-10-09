using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class NumRange
    {
        public int FindNumRange(int[] a, int b, int c)
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                int current = a[i];
                for(int j=i+1; current<=c&&j<a.Length;j++){
                    current += a[j];
                    if (current >= b && current <= c)
                        count++;
                }
            }
                return count;
        }
    }
}
