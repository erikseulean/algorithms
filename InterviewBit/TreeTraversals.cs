using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }
    public class TreeTraversals
    {
        public void PrintInorder(TreeNode tree)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode current = tree;
            stack.Push(tree);
            while (stack.Count > 0)
            {
                if (current.Left != null)
                {
                    stack.Push(current.Left);
                    current = current.Left;
                }
                else
                {
                    current = stack.Pop();
                    Console.Write(current.Value + " ");
                    if (current.Right != null)
                    {
                        current = current.Right;
                        stack.Push(current);
                    }

                }
            }
        }

        public void PreOrder(TreeNode tree)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode current = tree;
            stack.Push(tree);
            while (stack.Count > 0)
            {
                current = stack.Pop();
                Console.Write(current.Value + " ");
                if (current.Right != null)
                    stack.Push(current.Right);
                if (current.Left != null)
                    stack.Push(current.Left);
            }
        }
    }
}
