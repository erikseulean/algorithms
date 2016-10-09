using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Cents
    {
        private int n;
        private int[] values = {25, 10, 5, 1};
        private int[] data;
        List<int[]> list = new List<int[]>(); 
        public Cents(int n)
        {
            this.n = n;
            data = new int[n + 1];
        }

        public void Calculate()
        {
            Calculate(0);
            PrintAll();
        }

        public void Calculate(int k)
        {
            for (int i = 0; i < 3; i++)
            {
                data[k] = values[i];
                var sum = Sum(k);
                if(sum < n)
                    Calculate(k + 1);
                else if (sum == n) Store(k);
            }
        }

        private void Store(int k)
        {
            int[] array = new int[k+1];
            for (int i = 0; i <= k;i++)
                array[i] = data[i];
            list.Add(array);
        }
        
        

        public void PrintAll()
        {
            //list = list.Distinct(new ArrayEqualityComparer()).ToList();
            foreach (var array in list)
            {
                foreach (var item in array)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
        }

        private int Sum(int k)
        {
            int sum = 0;
            for (int i = 0; i <= k; i++)
                sum += data[i];
            return sum;
        }
    }

    public class ArrayEqualityComparer : IEqualityComparer<int[]>
    {
        public bool Equals(int[] x, int[] y)
        {
            return (from xitem in x from yitem in y where xitem != yitem select xitem).Any();
        }

        public int GetHashCode(int[] obj)
        {
            var sum = 0;
            foreach (var item in obj)
                sum += item.GetHashCode();
            return sum;
        }
    } 
}
