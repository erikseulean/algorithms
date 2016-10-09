using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProblems
{
    public class MyNode
    {
        public MyNode LeftNode { get; set; }
        public MyNode RightNode { get; set; }
        public int Value { get; set; }
    }

    public class LinkedListTree
    {
        private List<LinkedList<int>> list;
        private MyNode head;
        private int height = 0;

        public LinkedListTree()
        {
            this.head = new MyNode();
            list = new List<LinkedList<int>>();
            head.Value = 7;
            head.LeftNode = new MyNode()
            {
                Value = 5,
                LeftNode = new MyNode() {Value = 4},
                RightNode = new MyNode() {Value = 6}
            };
            head.RightNode = new MyNode()
            {
                Value = 9,
                LeftNode = new MyNode() {Value = 8},
                RightNode = new MyNode() {Value = 10}
            };
        }

        public void Add()
        {
            AddNodes(head,0);

        }

        private void AddNodes(MyNode head, int height)
        {
            if (head != null)
            {
                if (list.Count <= height)
                    list.Add(new LinkedList<int>());
                list[height].AddFirst(new LinkedListNode<int>(head.Value));
                AddNodes(head.LeftNode, height + 1);
                AddNodes(head.RightNode, height + 1);
            }
        }
    }
}
