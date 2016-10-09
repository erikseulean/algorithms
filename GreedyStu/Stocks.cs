using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyStu
{
    public class Stocks
    {
        private int[] dp;
        public int ReGreedy(int dayNumber, int stock, int[] array)
        {
            dp = Enumerable.Repeat(-1, array.Length).ToArray();
            return Greedy(dayNumber, stock, array);
            
        }
        public int Greedy(int dayNumber, int stock, int[] array)
        {
            if (dayNumber == array.Length) return 0;

            if (dp[dayNumber] != -1) return dp[dayNumber];

            int result = 0;
            if (stock !=-1)
            {
                if (array[dayNumber] > stock)
                {
                    result = Math.Max(array[dayNumber] - stock + Greedy(dayNumber + 1, -1, array), Greedy(dayNumber + 1, stock, array));
                    dp[dayNumber] = result;
                }
                else result = Greedy(dayNumber + 1, array[dayNumber], array);
            }
            else result = Greedy(dayNumber + 1, array[dayNumber], array);
            
            return result;
        }
    }
}
