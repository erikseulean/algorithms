using System;

namespace BinarySearchTree
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    public class BST
    {
        private Node Head;

        public Node getHead()
        {
            return Head;
        }

        public void AddNode(int value)
        {
            Node node = new Node(value);
            Add(node, Head);
        }

        public int GetNext(int value)
        {
            return GetNext(value, Head);
        }

        public int GetNext(int value, Node head)
        {
            if (head.Value == value && head.Right != null)
            {
                var node = head.Right;
                while (node.Left != null)
                {
                    node = node.Left;
                }
                return node.Value;
            }
            if (head.Value > value)
            {
                if (head.Left.Value == value)
                    if (head.Left.Right != null) return head.Left.Right.Value;
                    else return head.Value;
                return GetNext(value, head.Left);
            }
            else
            {
                if (head.Right.Value == value)
                    if (head.Right.Right != null) return head.Right.Right.Value;
                    else return head.Value;
                return GetNext(value, Head.Right);
            }
        } 
		
		 

        private void Add(Node node, Node head)
        {
            if (head == null)
                Head = node;
            else if (head.Value >= node.Value)
                if (head.Left == null) head.Left = node;
                else Add(node, head.Left);
            else if (head.Right == null) head.Right = node; else Add(node, head.Right);
        }

        public void InOrder()
        {
            InOrder(Head);
        }

        private void InOrder(Node Head)
        {
            if (Head.Left != null)
                InOrder(Head.Left);
            Console.Write(Head.Value + " ");
            if(Head.Right != null)
                InOrder(Head.Right);
        }

        public void PostOrder()
        {
            PostOrder(Head);
        }
        private void PostOrder(Node head)
        {
            if(head.Right != null)
                PostOrder(head.Right);
            Console.Write(head.Value + " ");
            if(head.Left != null)
                PostOrder(head.Left);
        }

        public void PreOrder()
        {
            PreOrder(Head);
        }

        private void PreOrder(Node head)
        {
            if(head != null)
                Console.Write(head.Value + " ");
            if(head.Left != null) PreOrder(head.Left);
            if(head.Right != null) PreOrder(head.Right);
        }

        public bool Find(int value)
        {
            return Find(value, Head);
        }
        private bool Find(int value, Node head)
        {
            if (head == null) return false;
            if (head.Value == value) return true;
            else if (head.Value > value)
                return Find(value, head.Left);
            else return Find(value, head.Right);
        }

        public void Remove(int value)
        {
            if (Find(value))
            {
                Remove(value, Head);
            }
        }

        //private void Remove(int value, Node head)
        //{
        //    if (head.Value == value)
        //    {
        //        if (head.Left != null)
        //        {
        //            Node newHead = head.Left;
        //            while (newHead.Right.Right != null)
        //                newHead = newHead.Right;
        //            head = newHead.Right.Right;
        //            newHead.Right.Right = null;
        //        }
        //        else if (head.Right != null)
        //        {
        //            Node newHead = head.Right;
        //            while (newHead.Left.Left != null)
        //                newHead = newHead.Left;
        //            head = newHead.Left.Left;
        //            newHead.Left.Left = null;
        //        }
        //        else head = null;
        //    }
        //    else if (head.Value > value) Remove(value, head.Left);
        //    else Remove(value, head.Right);
        //}

        private void Remove(int value, Node Head)
        {
            Node iterator = Head;
            Node parent = Head;
            bool replaced = true;
            while (replaced)
            {
                if (iterator.Value > value)
                {
                    parent = iterator;
                    iterator = iterator.Left;
                }
                else if (iterator.Value < value)
                {
                    parent = iterator;
                    iterator = iterator.Right;
                }
                else
                {
                    Node replacement;
                    if (iterator.Left != null)
                    {
                        replacement = iterator.Left;
                        parent = replacement;
                        if (replacement.Right == null)
                        {
                            iterator.Value = replacement.Value;
                            iterator.Left = null;
                            replaced = false;
                        }
                        else
                        {
                            while (replacement.Right != null)
                            {
                                parent = replacement;
                                replacement = replacement.Right;
                            }
                            iterator.Value = replacement.Value;
                            parent.Right = null;
                            replaced = false;
                        }
                    }
                    else if (iterator.Right != null)
                    {
                        replacement = iterator.Right;
                        parent = replacement;
                        if (replacement.Left == null)
                        {
                            iterator.Value = replacement.Value;
                            iterator.Right = null;
                            replaced = false;
                        }
                        else
                        {
                            while (replacement.Left != null)
                            {
                                parent = replacement;
                                replacement = replacement.Left;
                            }
                            iterator.Value = replacement.Value;
                            parent.Left = null;
                            replaced = false;
                        }
                    }
                    else
                    {
                        if (parent.Left != null && parent.Left.Value == value)
                            parent.Left = null; 
                        else if (parent.Right != null && parent.Right.Value == value) 
                            parent.Right = null;
                        replaced = false;
                    }
                }
            }

        }

        public void Print()
        {
            PrintSorted(Head);
        }

        private void PrintSorted(Node head)
        {
            if (head.Left != null)
                PrintSorted(head.Left);
            Console.Write(head.Value + " ");
            if (head.Right != null)
                PrintSorted(head.Right);
        }
    }  
					
}
