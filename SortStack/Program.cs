using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(2);
            stack.Push(3);
            stack.Push(1);
            stack.Push(9);
            stack.Push(7);
            Sorter sorter = new Sorter();
            sorter.SortStack(ref stack);
            while(stack.Count > 0)
                Console.Write(stack.Pop() + " ");
            Console.ReadLine();

        }
    }
}
