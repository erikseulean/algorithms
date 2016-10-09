using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class LongestZero
    {
        public List<int> lszero(List<int> a)
        {
            int min = 0;
            int max = 0;
            for (int i = 0; i < a.Count; i++)
            {
                int sum = 0;
                int j;
                for (j = i; j < a.Count; j++)
                    sum += a[j];
                if (sum == 0 && j - i > max - min)
                {
                    max = j;
                    min = i;
                }
            }
            List<int> solution = new List<int>();
            for (int i = min; i <= max; i++)
                solution.Add(a[i]);
            return solution;

        }

        public List<int> lzeroHash(List<int> a)
        {
            int[] array = new int[a.Count];
            int min = 0;
            int max = 0;
            array[0] = a[0];
            for (int i = 1; i < a.Count; i++)
                array[i] = array[i - 1] + a[i];
            if (array[a.Count - 1] == 0)
                return a;
            for (int i = 1; i < a.Count; i++)
            {
                if (array[i] == 0 && i > max - min)
                {
                    max = i;
                    min = 0;
                } 
                if (a.Count - 1 - i < max - min) break;
                for (int j = a.Count - 1; j >= i; j--)
                {
                    
                    if (array[j] - array[i - 1] == 0 && j - i > max - min)
                    {
                        max = j;
                        min = i;
                        break;
                    }
                    else if (j - i <= max - min) break;
                }
            }
                List<int> returnedList = new List<int>();
                for (int i = min; i <= max; i++)
                    returnedList.Add(a[i]);
                return returnedList;
        }
    }
}
