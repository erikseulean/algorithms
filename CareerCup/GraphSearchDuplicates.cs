using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }
    }
    public class GraphSearchDuplicates
    {
        private Node TreeHead;
        public GraphSearchDuplicates(Node head)
        {
            TreeHead = head;
        }

        public int CheckDuplicate(int count, Node head, int headValue, int leftValue, int rightValue)
        {
            int found = 0;
            if (head.Left == null || head.Right == null)
                return count;
            else if (head.Value == headValue && head.Right.Value == rightValue && head.Left.Value == leftValue)
                found++;
            return CheckDuplicate(count, head.Left, headValue, leftValue, rightValue) + CheckDuplicate(count, head.Right, headValue, leftValue, rightValue) + found;
        }

        public bool Iterate(Node head)
        {
            if (head == null || (head.Left == null && head.Right == null))
                return false;
            if (head.Left != null && head.Right != null && CheckDuplicate(0, TreeHead, head.Value, head.Left.Value, head.Right.Value) > 1)
                return true;
            return Iterate(head.Left) || Iterate(head.Right);

        }
    }
}
