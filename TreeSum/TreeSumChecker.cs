using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSum
{
    public class MyNode
    {
        public MyNode Left { get; set; }
        public MyNode Right { get; set; }

        public int Value { get; set; }

    }
    public class TreeSumChecker
    {
        private Stack<int> stack = new Stack<int>();
        private int sum;
        private MyNode Head;

        public TreeSumChecker(int sum)
        {
            this.sum = sum;
        }

        public void ComputeSum(MyNode head, int currentSum, int sum, string path)
        {
            if (head == null)
                return;
            currentSum += head.Value;
            if (currentSum == sum)
            {
                path += head.Value;
                Console.WriteLine(path);
            }
            if (currentSum < sum)
            {
                path += head.Value + " ";
                ComputeSum(head.Left, currentSum, sum, path);
                ComputeSum(head.Right, currentSum, sum, path);
                ComputeSum(head.Left, 0, sum, "");
                ComputeSum(head.Right, 0, sum, "");
            }
        }
    }
}
