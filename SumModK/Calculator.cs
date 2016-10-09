using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumModK
{
    public class Calculator
    {
        public List<int> GetSum(int[] array)
        {
            int[] cache = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
                array[i] %= array.Length;
            cache[0] = 1;
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();
            d.Add(0,new List<int>());
            for (int i = 0; i < array.Length; i++)
            {
                d.Add(array[i], new List<int>() { array[i] });
                cache[array[i]] = 1;
                for (int j = array[i]; j <= array.Length; j++)
                {
                    if (cache[j] == 0)
                    {
                        cache[j] += cache[j - array[i]];
                        if (cache[j] == 1 && !d.ContainsKey(j) && d.ContainsKey(array[i]))
                        {
                            d.Add(j, new List<int>(d[array[i]]));
                            d[j].Add(j - array[i]);
                        }
                    }
                    if (j == array.Length && cache[j] == 1) return d[j];
                }
            }
            return d[0];
        }
    }
}
