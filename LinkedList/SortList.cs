using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SortList
    {
        public Node Sort(Node head, int val)
        {
            Node n = new Node(null, val);
            n.Next = head;
            head = n;
            Node iterator = head.Next;
            Node prev = head;
            Node aux;
            while (iterator != null)
            {
                if (iterator.Value < val)
                {
                    prev.Next = iterator.Next;
                    aux = iterator.Next;
                    iterator.Next = head;
                    head = iterator;
                    iterator = aux;
                }
                else
                {
                    prev = prev.Next;
                    iterator = iterator.Next;
                }
            }
            return head;
        }
    }
}
