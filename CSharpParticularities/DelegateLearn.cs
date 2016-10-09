using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpParticularities
{

    public class DelegateLearn
    {
        private delegate void Foo();
        private delegate void Bar();
        private delegate void Composed();

        private Foo foo;
        private Bar bar;
        private Action a;
        public DelegateLearn()
        {
            foo = WriteFoo;
            bar = WriteBar;

            a = new Action(WriteFoo) + WriteBar;
        }

        public void CallFoo()
        {
            foo();
        }

        public void CallBar()
        {
            bar();
        }

        public void CallAction()
        {
            a();
        }

        public void WriteFoo()
        {
            Console.WriteLine("Foo");
        }

        public void WriteBar()
        {
            Console.WriteLine("Bar");
        }
    }
}
