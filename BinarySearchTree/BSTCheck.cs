using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BSTCheck
    {
        private List<int> list;
        private int previousValue;
        public BSTCheck()
        {
            list = new List<int>();
        }

        public bool Check(Node node)
        {
            bool increase = true;
            bool decrease = true;
            CreateInorder(node);
            for (int i = 0; i < list.Count - 1;i++ )
            {
                if (list[i] < list[i + 1])
                    decrease = false;
                if (list[i] > list[i + 1])
                    increase = false;
            }
            return decrease || increase;
        }

        private void CreateInorder(Node head)
        {
            if (head == null)
                return;
            if (head.Left != null)
                CreateInorder(head.Left);
            list.Add(head.Value);
            if (head.Right != null)
                CreateInorder(head.Right);
        }
    }
}
