using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public interface InterfaceDemo
    {
       
       void Nhap();
        void HienThi();
    }

    public interface Demo1<T>
    {
        T GetValue(T item);
    }
}
