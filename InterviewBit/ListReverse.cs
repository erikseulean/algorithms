using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class Node{
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class ListReverse
    {
        public Node ReverseList(Node head)
        {
            if (head == null) return null;
            Node iterator = head.Next.Next;
            Node toSwap = head.Next;
            toSwap.Next = head;
            head.Next = null;
            head = toSwap;
            while (iterator != null)
            {
                toSwap = iterator;
                iterator = iterator.Next;
                toSwap.Next = head;
                head = toSwap;
            }
            return head;
        }

        public int Palindrome(Node head){
            Node iterator;
            Node fastIterator;
            iterator = head;
            fastIterator = head;
            while (fastIterator.Next != null && fastIterator != null)
            {
                iterator = iterator.Next;
                fastIterator = fastIterator.Next.Next;
            }

            iterator.Next = ReverseList(iterator.Next);
            Node start = head;
            Node secondStart = iterator.Next;
            while (start != null && secondStart != null)
            {
                if (start.Value != secondStart.Value)
                    return 0;
                start = start.Next;
                secondStart = secondStart.Next;
            }

            return 1;
        }
    }
}
