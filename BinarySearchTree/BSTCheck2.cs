using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BSTCheck2
    {

        private int previousValue;
        
        public bool CheckTree(Node node,int min, int max){
            if (node == null)
                return true;
            if (node.Value < min || node.Value > max)
                return false;
            else return CheckTree(node.Left, min, node.Value) && CheckTree(node.Right, node.Value, max);
            return true;
        }

        public bool Check(Node head)
        {
            return CheckTree(head, int.MinValue, int.MaxValue);
        }
    }
}
