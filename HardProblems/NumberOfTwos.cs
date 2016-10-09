using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class NumberOfTwos
    {
        private int[] array;
        private int counter;
        public NumberOfTwos()
        {
            array = new int[1000];
        }
        public int NrTwos(int nr, int digits, int pos)
        {
            if (digits < pos) return nr;
            nr += Convert.ToInt32(Math.Pow(10, digits - pos) * Math.Pow(9, pos));
            return NrTwos(nr, digits, pos + 1);
        }

        public void NumberParse(int number)
        {
            int counter = 0;
            while(number !=0)
            {
                array[counter] = number % 10;
                number = number / 10;
                counter++;
            }
            counter--;
            this.counter = counter;
        }

        public int Calculate(int number)
        {
            NumberParse(number);
            int total = 0;
            for (int i = counter; i > 0; i--)
                total += array[i] * NrTwos(0, i - 1, 0);
            if (array[0] >= 2)
                total += 1;
            return total;
        }
    }
}
