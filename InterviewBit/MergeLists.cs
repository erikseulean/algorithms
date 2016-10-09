using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class MergeLists
    {
        public Node Merge(Node a, Node b)
        {
            if (a == null) return b;
            if (b == null) return a;
            Node aux;
            if (a.Value > b.Value)
            {
                aux = a;
                a = b;
                b = aux;
            }
            Node n1 = a;
            Node n2 = b;
            while (n1 != null && n2 != null)
            {
                if (n1.Value < n2.Value)
                {
                    aux = n2.Next;
                    n2.Next = n1.Next;
                    n1.Next = n2;
                    n1 = n1.Next;
                    n2 = aux;
                }
                else if (n1.Next == null)
                {
                    n1.Next = n2;
                    return a;
                }
                else n1 = n1.Next;
            }
            return a;
        }
    }
}
