using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCheck
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    
    class Program
    {
        public static int Middle(Node list)
        {
            if (list == null) return -1;
            if (list.Next == null) return list.Value;

            Node head = list;
            Node it = list.Next;
            int count = 0;
            while (it != null)
            {
                count++;
                it = it.Next;
            }
            it = head;
            count = count / 2;
            while (count-- > 0)
                it = it.Next;
            
            return it.Value;
        }
        static void Main(string[] args)
        {
            Node n8 = new Node();
            n8.Value = 8;
            Node n7 = new Node();
            n7.Value = 7;
            n7.Next = n8;
            Node n6 = new Node();
            n6.Value = 6;
            n6.Next = n7;
            Node n5 = new Node();
            n5.Value = 5;
            n5.Next = n6;
            Node n4 = new Node();
            n4.Value = 4;
            n4.Next = n5;
            Node n3 = new Node();
            n3.Value = 3;
            n3.Next = n4;
            Node n2 = new Node();
            n2.Value = 2;
            n2.Next = n3;
            Node n1 = new Node();
            n1.Value = 1;
            n1.Next = n2;
            Console.WriteLine(Middle(n1));
            Console.ReadLine();
        }
    }
}
