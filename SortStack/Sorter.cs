using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStack
{
    public class Sorter
    {
        public void SortStack(ref Stack<int> stack)
        {
            if (stack != null)
            {
                var extra = new Stack<int>();
                while (stack.Count > 0)
                {
                    int intValue = stack.Pop();
                    while (extra.Count > 0 && extra.Peek() > intValue)
                        stack.Push(extra.Pop());
                    extra.Push(intValue);
                }

                while (extra.Count > 0)
                {
                    stack.Push(extra.Pop());
                }
            }
        }
    }
}
