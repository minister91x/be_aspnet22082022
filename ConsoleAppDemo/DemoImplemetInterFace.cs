using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class DemoImplemetInterFace : InterfaceDemo
    {
        public void Save()
        {
            Console.WriteLine("thuc hien cong viec");
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
       public class DemoGenericImplemetInterFace<T> : Demo1<T>
    {
        public T GetValue(T item)
        {
            return item;
        }
    }
}
