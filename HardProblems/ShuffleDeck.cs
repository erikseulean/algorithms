using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class ShuffleDeck
    {
        public int[] CreateArray()
        {
            int[] array = new int[52];
            for (int i = 0; i < array.Length; i++)
                array[i] = i + 1;
            return array;
        }

        public void Shuffle(int[] array)
        {
            Random r = new Random();
           
            while (array.Length != 0)
            {
                int nr = r.Next(array.Length - 1);
                Console.Write(array[nr] + " ");
                for (int i = nr + 1; i < array.Length; i++)
                    array[i - 1] = array[i];
                array = array.Take(array.Length - 1).ToArray();
            }
        }

        public void AnotherShuffle(int[] array)
        {
            Random r = new Random();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int index = r.Next(i);
                Console.WriteLine(array[index] + " ");
                int aux = array[i];
                array[i] = array[index];
                array[index] = aux;
            }
        }

        public void Shuffle()
        {
            AnotherShuffle(CreateArray());
        }
    }
}
