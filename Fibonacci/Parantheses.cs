using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Parantheses
    {
        private int number;
        private int[] values;
        public Parantheses(int number)
        {
            this.number = number;
            values = new int[number+1];
        }

        public void Sum()
        {
            Sum(0);
        }

        private void Sum(int k)
        {
            for (int i = 1; i <= number; i++)
            {
                values[k] = i;
                var intSum = CheckSum(k);
                if (intSum < number) Sum(k + 1);
                else if (intSum == number) Print(k);
            }
        }

        private void Print(int k)
        {
            for (int i = 0; i <= k; i++)
            {
                //Console.Write(values[i] + " ");
                for (int j = 0; j < values[i]; j++)
                    Console.Write("(");
                for (int j = 0; j < values[i]; j++)
                    Console.Write(")");
                
            }
            Console.WriteLine();
                
        }

        public int CheckSum(int k)
        {
            int sum = 0;
            for (int i = 0; i <= k; i++)
                sum += values[i];
            return sum;
        }
    }
}
