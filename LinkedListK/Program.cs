using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListK
{
    public class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }

        public Node(Node next, int value)
        {
            Next = next;
            Value = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(null,12);
            Node n2 = new Node(n1, 11);
            Node n3 = new Node(n2, 10);
            Node n4 = new Node(n3, 9);
            Node n5 = new Node(n4, 8);
            Node n6 = new Node(n5, 7);
            Node n7 = new Node(n6, 6);
            Node n8 = new Node(n7, 5);
            Node n9 = new Node(n8, 4);
            Node n10 = new Node(n9, 3);
            Node n11 = new Node(n10, 2);
            Node n12 = new Node(n11, 1);
            n12 = ReverseList(n12, 3);
        }

        public static void Reverse(Node l, int k)
        {
            int count = 0;
            Node it = l.Next;
            Node nexte = it.Next;
            Node head = l;
            head.Next = null;
            Node connector = head;
            Node nextHead = null;
            Node prev = null;
            bool first = true;
            while (it != null)
            {
                it.Next = head;
                head = it;
                it = nexte;
                if (nexte != null)
                    nexte = nexte.Next;
                count++;
                if (count == k - 1)
                {
                    if (first)
                    {
                        nextHead = head;
                        first = false;
                    }
                    if (prev != null)
                        prev.Next = head;
                    prev = connector;
                    connector = it;
                    head = it;
                    if (head == null) break;
                    it = head.Next;
                    head.Next = null;
                    if (it != null)
                        nexte = it.Next;
                    count = 0;
                }
            }
            prev.Next = head;
        }

        public static Node ReverseList(Node head, int k)
        {
            if (head == null) return null;

            Node it = head.Next;
            head.Next = null;
            Node tail = head;
            Node nexte = it.Next;
            int count = 0;
            while (it != null && count != k - 1)
            {
                it.Next = head;
                head = it;
                it = nexte;
                if (nexte != null)
                    nexte = nexte.Next;
                count++;
            }

            tail.Next = ReverseList(it, k);
            return head;
        }
    }
}
