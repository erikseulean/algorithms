using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //var task =  Task.Factory.StartNew(() => DateTime.Now);
            ////var t = new Task(() => Console.WriteLine("New Time " + DateTime.Now));
            //var taskNew = task.ContinueWith(t => Console.WriteLine(t.Result));

            //taskNew.Wait();

            ////t.Start();
            ////t.Wait();

            //Thread thread = new Thread(() => Console.WriteLine(DateTime.Now));
            //thread.Start();
            

            //Console.ReadLine();

            //SingletonTemplate template = new SingletonTemplate();
            //template.RegisterInstance(new A());
            //template.RegisterInstance(new B());
            //template.RegisterInstance(new C());
            //template.RegisterInstance(new A());

            //var instance = template.GetInstance<B>(new B().GetType());
    
        
            AutoKillingThread threadClass = new AutoKillingThread();
            Thread t = new Thread(threadClass.DoLockStuff);
            t.Start();

            Thread t1 = new Thread(threadClass.DoLockStuff);
            t1.Start();

            Console.ReadLine();
        }
    }
}
