using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyCustomStack
    {
        private int stackSize;
        private int[] stackNumber = {0, 100, 200};
        private int[] stack;

        public MyCustomStack(int stackSize)
        {
            for (int i = 0; i < 3; i++)
                stackNumber[i] = i*stackSize;
            stack = new int[stackSize*3];
        }

        public void Push(int stackNr, int value)
        {
            if (stackNr >= 0 && stackNr <= 2 && stackNumber[stackNr] < stackNr*stackSize - 1)
            {
                stack[stackNumber[stackNr]] = value;
                stackNumber[stackNr]++;
            }
        }

        public int Pull(int stackNr)
        {
            if (stackNumber[stackNr]%stackSize != 0)
            {
                int oldNr = stackNumber[stackNr];
                stackNumber[stackNr] --;
                return stack[oldNr];
            }
            else return -1;
        }
    }

    public class StackElement
    {
        public StackElement(int prev, int value)
        {
            Previous = prev;
            Value = value;
        }

        public int Previous { get; set; }
        public int Value { get; set; }

    }

    public class Stack
    {
        private int[] last = {0, 0, 0};
        private int count;
        private int stackSize;
        private StackElement[] stack;

        public Stack(int stackSize)
        {
            stack = new StackElement[stackSize];
            this.stackSize = stackSize;
        }

        private bool canAdd()
        {
            if (count != stackSize)
                return true;
            return false;
        }

        private bool canRemove()
        {
            if (count > 0) return true;
            else return false;
        }

        public void push(int stackNr, int value)
        {
            if (stackNr >= 0 && stackNr <= 2 && canAdd())
            {
                {
                    StackElement element = new StackElement(last[stackNr], value);
                    stack[count] = element;
                    last[stackNr] = count;
                    count++;
                }
            }
        }

        public StackElement pull(int stackNr)
        {
            if (stackNr >= 0 && stackNr <= 2 && canRemove())
            {
                StackElement elem = stack[last[stackNr]];
                if (elem != null)
                {
                    stack[last[stackNr]] = null;
                    last[stackNr] = elem.Previous;
                    count--;
                    return elem;
                }
            }
            return null;
        }
    }
}

        
