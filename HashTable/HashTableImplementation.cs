using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTableImplementation
    {
        private int _size;
        private int[] _array;

        public HashTableImplementation(int size)
        {
            _size = size;
            _array = new int[size];
        }

        public void AddItem(int item)
        {
            var hashCode = item.GetHashCode();
            _array[hashCode%_size] = item;
        }

        public int GetItem(int item)
        {
            var hashCode = item.GetHashCode();
            return _array[hashCode%_size];
        }

    }
}
