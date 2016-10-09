using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestCommonAncestor
{
    public class MyNode
    {
        public MyNode Left { get; set; }
        public MyNode Right { get; set; }

        public int Value { get; set; }

    }
    public class BinaryTree
    {
        private MyNode Head;
        private MyNode Subtree;
        private MyNode Subtree2;
        private MyNode BadSubtree;
        #region constructor
        public BinaryTree()
        {
            Subtree = new MyNode();
            Subtree.Value = 5;
            Subtree.Left = new MyNode() {Value = 2, Left = new MyNode() {Value = 1}};
            Subtree.Right = new MyNode(){ Value = 6};

            Subtree2 = new MyNode() {Value = 9, Left = new MyNode() {Value = 8}, Right = new MyNode() {Value = 10}};
            BadSubtree = new MyNode() { Value = 4, Left = new MyNode(){Value = 5} };

            Head = new MyNode();
            Head.Value = 7;
            Head.Left = Subtree;
            Head.Right = Subtree2;

        }
        #endregion

        public MyNode FindParent(int value, MyNode head)
        {
            Queue<MyNode> queue = new Queue<MyNode>();
            queue.Enqueue(head);
            while (queue.Count > 0)
            {
                MyNode node = queue.Dequeue();
                if (node == null) return null;
                if (node.Value == value) return null;
                if ((node.Left != null && node.Left.Value == value) ||
                         (node.Right != null && node.Right.Value == value)) return node;
                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }
            return null;
        }

        public bool isSon(int value, MyNode head)
        {
            Queue<MyNode> queue = new Queue<MyNode>();
            queue.Enqueue(head);
            while (queue.Count > 0)
            {
                MyNode node = queue.Dequeue();
                if (node == null)
                    return false;
                if (node.Value == value) return true;
                else if ((node.Left != null && node.Left.Value == value) ||
                         (node.Right != null && node.Right.Value == value)) return true;
                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }
            return false;
        }

        public bool checkTree(MyNode t1, MyNode t2)
        {
            if (t1 == null && t2 != null) return false;
            if (t1 != null && t2 != null && t1.Value == t2.Value)
                    return checkTree(t1.Left, t2.Left) && checkTree(t1.Right, t2.Right);
            if (t1 != null && t2 != null && t1.Value != t2.Value) return false;
            return true;
        }
        
        public bool checkSubtree(MyNode t1, MyNode t2)
        {
            if (t1 == null) return false;
            if (checkTree(t1, t2)) return true;
            return checkSubtree(t1.Left, t2) || checkSubtree(t1.Right, t2);
        }

        public void checkSubtree()
        {
            Console.WriteLine(checkSubtree(Head,BadSubtree));
            Console.ReadLine();
        }

        public int LCA(int first, int second)
        {
            MyNode firstParent = FindParent(first, Head);
            bool found = false;
            while (!found && firstParent != null)
            {
                found = isSon(second, firstParent);
                if (found) return firstParent.Value;
                firstParent = FindParent(firstParent.Value, Head);
            }
            return -1;
        }
    }
}
