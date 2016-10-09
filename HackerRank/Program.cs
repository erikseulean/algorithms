using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static int[] letters;
        static void Main(String[] args)
        {
            int[] arr = { 90, 30, 100, 40, 20 };
            int sum = 0;
            int newYear = 210;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            int diff = sum - newYear;
            while (sum != newYear)
            {
                int s = 0;
                for (int i = 0; i < arr.Length; i++)
                    s += Math.Min(diff, arr[i]);
                sum = s;
                if (sum > newYear) diff -= diff / 2;
                else if (sum < newYear) diff += diff / 2;
            }
            Console.WriteLine(diff);
        }
    }
}
