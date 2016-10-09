using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList
    {
        public Node Head { get; set; }

        public MyLinkedList(Node head)
        {
            Head = head;
        }

        public void AddNode(Node node)
        {
            if (Head == null)
                Head = node;
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public void AddNodeAtEnd(Node n)
        {
            if (Head == null)
                Head = n;
            else
            {
                Node iterator = Head;
                while (iterator.Next != null)
                    iterator = iterator.Next;
                iterator.Next = n;
            }
        }

        public void PrintList()
        {
            Node Iterator = Head;
            while (Iterator != null)
            {
                Console.Write(Iterator.Value + " ");
                Iterator = Iterator.Next;
            }
        }

        public void RemoveDuplicateOnsquared()
        {
            if (Head != null)
            {
                Node first = Head;
                Node second = Head.Next;
                Node previous = Head;
                while (first.Next != null)
                {
                    while (second != null)
                    {
                        if (first.Value == second.Value)
                        {
                            previous.Next = second.Next;
                            second = second.Next;
                        }
                        else
                        {
                            previous = second;
                            second = second.Next;
                        }
                    }
                    first = first.Next;
                    previous = first;
                    second = first.Next;
                }
            }
        }

        public void RemoveDuplicatesOn()
        {
            if (Head != null && Head.Next != null)
            {
                List<int> list = new List<int>();
                list.Add(Head.Value);
                Node iterator = Head.Next;
                Node previous = Head;
                while (iterator != null)
                {
                    if (list.Contains(iterator.Value))
                    {
                        previous.Next = iterator.Next;
                        iterator = iterator.Next;
                    }
                    else
                    {
                        list.Add(iterator.Value);
                        previous = previous.Next;
                        iterator = iterator.Next;
                    }
                }
            }
        }

        public void NthToLast(int n)
        {
            if (n > 0 && Head != null)
            {
                Node iterator = Head;
                while (n != 0 && iterator != null)
                {
                    iterator = iterator.Next;
                    n--;
                }
                while (iterator != null)
                {
                    Console.Write(iterator.Value + " ");
                    iterator = iterator.Next;
                }
            }
        }

        public void RemoveNodeInList(Node n)
        {
            if (n != null && n.Next != null)
            {
                n.Value = n.Next.Value;
                n.Next = n.Next.Next;
            }

        }

        public MyLinkedList SumLists(Node HeadFirst, Node HeadSecond)
        {
            if (HeadFirst == null && HeadSecond == null)
                return null;
            MyLinkedList list = new MyLinkedList(null);
            int sum = 0; int overflow = 0;
            while (HeadFirst != null && HeadSecond != null)
            {
                sum = HeadFirst.Value + HeadSecond.Value + overflow;
                list.AddNodeAtEnd(new Node(null,sum % 10));
                overflow = sum / 10;
                HeadFirst = HeadFirst.Next;
                HeadSecond = HeadSecond.Next;
            }

            if (HeadFirst == null)
                while (HeadSecond != null)
                {
                    sum = overflow + HeadSecond.Value;
                    list.AddNodeAtEnd(new Node(null,sum % 10));
                    overflow = sum / 10;
                    HeadSecond = HeadSecond.Next;
                }
            if (HeadSecond == null)
                while (HeadFirst != null)
                {
                    sum = overflow + HeadFirst.Value;
                    list.AddNodeAtEnd(new Node(null,sum % 10));
                    overflow = sum / 10;
                    HeadFirst = HeadFirst.Next;
                }
            return list;
        }



    }
}
