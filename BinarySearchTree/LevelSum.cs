using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class LevelSum
    {
        private int[] array;

        public void CreateArray(Node head)
        {
            array = new int[20];
            Iterate(head, 0);
            Print();

        }

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        private void Iterate(Node head, int level)
        {
            if (head == null)
                return;
            array[level] += head.Value;
            Iterate(head.Left, level + 1);
            Iterate(head.Right, level + 1);
        }
    }
}
