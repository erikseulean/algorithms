using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class MyStack
    {

        private int capacity;
        private int[] array;
        private int counter;

        public MyStack(int capacity)
        {
            this.capacity = capacity;
            array = new int[capacity];
            counter = 0;
        }

        public bool isEmpty()
        {
            if (counter == 0) return true;
            else return false;
        }

        public void push(int value)
        {
            if (counter == capacity)
                throw new Exception();
            array[counter] = value;
            counter++;
        }

        public int pull()
        {
            if (counter > 0)
            {
                counter--;
                int value = array[counter];
                array[counter] = 0;
                return value;
            }
            return -1;
        }

        public int peek()
        {
            return array[counter - 1];
        }

    }

    public class SetOfStacks
    {

        public int capacity;
        public int counter;
        public List<MyStack> stacks;

        public SetOfStacks(int capacity)
        {
            this.capacity = capacity;
            counter = 0;
            stacks = new List<MyStack>();
        }

        public void push(int value)
        {
            if (counter%capacity == 0)
                stacks.Add(new MyStack(capacity));
            stacks[counter/capacity].push(value);
            counter++;
        }

        public int pull()
        {
            if (counter > 0)
            {
                counter = counter - 1;
                int value = stacks[counter/capacity].pull();
                if (counter%capacity == 0) stacks.Remove(stacks[counter/capacity]);
                return value;
            }
            return -1;
        }
    }
}
