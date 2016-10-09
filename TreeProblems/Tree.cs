using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProblems
{
    public class Tree
    {
        private Node head;
        public Tree()
        {
            head = new Node();
            head.Value = 1;
            var firstLeaf = new Node();
            var secondLeaf = new Node();
            var thirdLeaf = new Node();
            var fourthLeaf = new Node();
            var fifthLeaf = new Node();
            var sixthLeaf = new Node();
            var seventLeaf = new Node();

            head.Nodes.Add(firstLeaf);
            firstLeaf.Nodes.Add(secondLeaf);
            secondLeaf.Nodes.Add(thirdLeaf);
            thirdLeaf.Nodes.Add(fourthLeaf);
            fourthLeaf.Nodes.Add(fifthLeaf);

            head.Nodes.Add(sixthLeaf);
            sixthLeaf.Nodes.Add(seventLeaf);
        }

        private int min;
        private int max;

        public bool CheckBalanced()
        {
            min = int.MaxValue;
            max = int.MinValue;
            GetMinMax(head, 0);
            if (max - min > 1)
                return false;
            return true;
        }


        public void GetMinMax(Node head, int height)
        {
            if (head.Nodes.Count == 0)
            {
                if (height > max)
                    max = height;
                if (height < min)
                    min = height;
            }
            for (int i = 0; i < head.Nodes.Count; i++)
                GetMinMax(head.Nodes[i], height + 1);
        }
		


    }
}
