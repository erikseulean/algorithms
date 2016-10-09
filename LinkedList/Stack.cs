using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyStack
    {
        private Node Head;

        public void Push(int value)
        {
            Node node = new Node(null,value);
            if (Head == null)
                Head = node;
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public Node Pull()
        {
            if (Head == null)
                return null;
            Node oldHead = Head;
            Head = Head.Next;
            return oldHead;

        }
    }
}
