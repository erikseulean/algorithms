using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{

            //    int[] array = { -2, -1, -2, -7, -1, -2, -3 };
            //int[,] matrix = { {2,1,-3,-4, 5},
            //                {0,6,3,4,1},
            //                {2,-2,-1,4,-5},
            //                {-3,3,1,0,3},
            //                {-5,-3,-63,-14,5}};
            //MaximumSubmatrix submatrix = new MaximumSubmatrix();
            //submatrix.CalculateMax(matrix,5);
            //submatrix.MaxSubMatrix(matrix);

    class Program
    {
        static void Main(string[] args)
        {

            List<Numbers> numbers = new List<Numbers>();
            numbers.Add(new Numbers() { Small = 1, Big = 2 });
            numbers.Add(new Numbers() { Small = 3, Big = 5 });
            numbers.Add(new Numbers() { Small = 6, Big = 7 });
            numbers.Add(new Numbers() { Small = 8, Big = 10 });
            numbers.Add(new Numbers() { Small = 12, Big = 16 });

            Overlapping lapping = new Overlapping();
            var list = lapping.Check(numbers, new Numbers() { Big = 9, Small = 4 });
            
            Console.ReadLine();
            //var list = lapping.Check(first, second);
        }
    }
}
