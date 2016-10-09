using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParticularities
{

    public class YieldReturnCheck
    {
        public IEnumerable<int> GetNumbers()
        {
            int sum = 0;
            for(int i=0;i<100;i++){
                //sum += i;
                yield return i;
            }
        }
    }

    public class PlayingWithGenerics<T>
    {
        public T AddNumbers(T first, T second)
        {
            //return (T)Convert.ChangeType(Convert.ToDouble(first) + Convert.ToDouble(second),typeof(T));
            return adder(first, second);
        }

        public readonly Func<T, T, T> adder;

        public PlayingWithGenerics()
        {
            var p1 = Expression.Parameter(typeof(T));
            var p2 = Expression.Parameter(typeof(T));
            adder = (Func<T,T,T>)Expression.Lambda(Expression.Add(p1,p2),p1,p2).Compile();
        }
          
    }

    public class IntegerAdd : PlayingWithGenerics<int>
    {

    }


    class Program
    {
        private delegate int d(int i);
        private delegate bool Odd(int i);
        private delegate string NamePrint(string s, string t);
        private delegate IEnumerable<int> GetNumbers(List<int> list);
        static void Main(string[] args)
        {
            d del = x => x * x;
            Odd odd = i => i % 2 == 0;
            NamePrint name = (s,t) => s + " " + t;
            GetNumbers nrs = (s) => s.Where(i => odd(i));
            List<int> numbers = new List<int>();
            Func<string, string, string> print = delegate(string s, string t)
            {
                return s + " " + t;
            };
            //PlayingWithGenerics<string> pwg = new PlayingWithGenerics<string>();
            //Console.WriteLine(pwg.AddNumbers("ana", "blandiana"));
            //IntegerAdd intadd = new IntegerAdd();
            //Console.WriteLine(intadd.adder(1, 3));

            YieldReturnCheck yrc = new YieldReturnCheck();
            foreach (int value in yrc.GetNumbers())
            {
                numbers.Add(value);
            }

            //Console.WriteLine(print("erik", "cristian"));
            //Console.WriteLine(name("erik","seulean"));
            //foreach(int value in nrs(numbers))
            //    Console.WriteLine(value);
            DelegateLearn dl = new DelegateLearn();
            dl.CallFoo();
            dl.CallBar();
            dl.CallAction();
            Console.ReadLine();
        }
    }
}
