using Fibonacci.reviews;
using System;


namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Permutations perm = new Permutations();
            perm.Permute("abcd".ToCharArray());
            Console.ReadLine();
        }
    }
}
