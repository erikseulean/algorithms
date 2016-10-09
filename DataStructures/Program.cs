using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); //add remove
            Queue<int> queue = new Queue<int>(); //enqueue dequeue
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(new LinkedListNode<int>(3));
            Dictionary<int,int> dict = new Dictionary<int,int>();
            HashSet<int> set = new HashSet<int>();
            string str = "ala bala";
            var x = str.Split(' ');
            //x.Sort();
        }
    }
}
