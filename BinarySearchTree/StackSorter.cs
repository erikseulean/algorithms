using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stacks;

namespace BinarySearchTree
{
    public class StackSorter
    {
        private MyStack stack;
        private BST tree;

        public StackSorter(MyStack stack)
        {
            this.stack = stack;
            tree = new BST();
        }

        public void SetTree()
        {
            while (!stack.isEmpty())
                tree.AddNode(stack.pull());
        }

        public void Sort()
        {
            SetTree();
            Sort(tree.getHead());
        }

        private void Sort(Node Head)
        {
            if (Head.Left != null)
                Sort(Head.Left);
            stack.push(Head.Value);
            if (Head.Right != null)
                Sort(Head.Right);
        }
    }
}
