using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            SayMyName name = new SayMyName();
            Thread t = new Thread(name.SayItLoud);
            t.Start();
            Thread t1 = new Thread(name.SayItAgain);
            t1.Start();
            Console.ReadLine();
        }
    }
}
