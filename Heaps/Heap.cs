using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class Heap
    {
        private int[] array;
        private int length = 1;
        private int maxLength;
        public delegate bool Comparator(int val1, int val2);
        private Comparator comparator;
        public Heap(int maxLength, Comparator comparator)
        {
            this.comparator = comparator;
            array = new int[1000];
            this.maxLength = maxLength;
        }

        public int Head { get { return array[1]; } }

        public int Length { get { return length; } }

        public void Insert(int number)
        {

            if (length == maxLength)
            {
                if (array[1] > number)
                    return;
                this.Remove();
            }
            array[length] = number;
            int oldLength = length;
            int parent = length / 2;
            length++;
            while(oldLength != 0 && parent !=0 && comparator(array[parent], array[oldLength]))
            {
                int aux = array[parent];
                array[parent] = array[oldLength];
                array[oldLength] = aux;
                oldLength = parent;
                parent = parent/2;
            }

        }

        public int Remove()
        {
            int index;
            int aux;
            int value = array[1];
            array[1] = array[length-1];
            array[length - 1] = 0;
            length--;
            index = 1;
            while((comparator(array[index], array[index * 2]) || comparator(array[index], array[index * 2 + 1])) && (index * 2 < length && (index* 2 + 1)<length))
            {
                if (!comparator(array[index * 2], array[index * 2 + 1]))
                {
                    aux = array[index * 2];
                    array[index * 2] = array[index];
                    array[index] = aux;
                    index = index * 2;
                }
                else
                {
                    aux = array[index * 2 + 1];
                    array[index * 2 + 1] = array[index];
                    array[index] = aux;
                    index = index * 2 + 1; 
                }
            }
            return value;
        }

        private bool Greater(int val1, int val2)
        {
            return val1 > val2;
        }

        public void Print()
        {
            for (int i = 1; i < length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
