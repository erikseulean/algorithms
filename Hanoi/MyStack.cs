using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class MyStack
    {
        private int[] array;
        private int capacity;
        public MyStack()
        {
            capacity = 0;
            array = new int[1000];
        }

        public void push(int value)
        {
            array[capacity] = value;
            capacity++;
        }

        public int pull()
        {
            if (capacity > 0)
            {
                capacity--;
                int value = array[capacity];
                array[capacity] = 0;
                return value;
            }

            return -1;

        }

        public void printValues()
        {
            while(capacity != 0)
                Console.WriteLine(pull());
        }

        public int peek()
        {
            return array[capacity - 1];
        }
    }
}
