using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class XeContainer : Car
    {
        public XeContainer(string name, string width, string height) : base(name, width, height)
        {
            Console.WriteLine(name);
        }

        public int Rmooc { get; set; }
        List<Car> cars { get; set; }

        
     
    }
}
