using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stacks;

namespace BinarySearchTree
{
    public class MyNewStackSorter
    {
        private MyStack stack;
        private MyStack extraStack;

        public MyNewStackSorter(MyStack stack)
        {
            this.stack = stack;
            extraStack = new MyStack(200);
        }

        public void sort()
        {
            int value;
            while (!stack.isEmpty())
            {
                value = stack.pull();
                while (!extraStack.isEmpty() && value > extraStack.peek())
                    stack.push(extraStack.pull());
                extraStack.push(value);
            }

            while(!extraStack.isEmpty())
                stack.push(extraStack.pull());
        }
    }
}