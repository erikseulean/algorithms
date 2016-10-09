using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class A
    {
        
    }

    public class B
    {
        
    }

    public class C
    {
        
    }

    public class SingletonTemplate
    {
        private List<object> list = new List<object>();

        public T GetInstance<T>(Type type)
        {
            foreach(var item in list)
                if (item.GetType() == type)
                    return (T) item;
            return default(T);
        }

        public void RegisterInstance<T>(T toRegister)
        {
            if(this.GetInstance<T>(toRegister.GetType()) == null)
                list.Add(toRegister);
        }
    }
}
