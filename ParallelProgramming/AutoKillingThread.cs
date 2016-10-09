using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ParallelProgramming
{



    public class AutoKillingThread
    {
        private Object lockObject = new object();
    



        public void DoLockStuff()
        {

            Task.Factory.StartNew(() => Console.WriteLine("bla"))
                .ContinueWith(t => Console.WriteLine("la"))
                .ContinueWith(t => Console.WriteLine("la"));
            Monitor.Enter(lockObject);
            try
            {
                Console.WriteLine("ThreadId:" + Thread.CurrentThread.ManagedThreadId);
                var timer = new System.Timers.Timer(5000);
                timer.Elapsed += timer_Elapsed;
                timer.Start();

                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("Counting " + i + " ...");
                    Thread.Sleep(1000);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Time elapsed, ending thread " + Thread.CurrentThread.ManagedThreadId);
            Monitor.Exit(lockObject);
            
        }
    }
}
