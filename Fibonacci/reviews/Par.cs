using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.reviews
{
    public class Par
    {
        private int[] array;
        public Par()
        {
            array = new int[100];
        }

        public void Parantheses(int sum, int poz)
        {
            for(int i=1;i<=sum;i++)
            {
                array[poz] = i;
                int nowSum = Valid(poz);
                if (nowSum == sum)
                    Print(poz);
                else if (nowSum < sum)
                    Parantheses(sum, poz + 1);
            }
        }

        public void Print(int poz)
        {
            for (int i = 0; i <= poz; i++)
            {
                for (int j = 0; j < array[i]; j++)
                    Console.Write("(");
                for (int j = 0; j < array[i]; j++)
                    Console.Write(")");
            }
            Console.WriteLine();
        }

        public int Valid(int poz)
        {
            int sum = 0;
            for (int i = 0; i <= poz; i++)
                sum += array[i];
            return sum;
        }
    }
}
