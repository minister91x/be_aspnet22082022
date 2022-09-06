using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class Car
    {
        public string Name { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }

        public Car(string name, string width, string height)
        {
            Name = "Car Name";
            Width = width;
            Height = height;
            Console.WriteLine("Car Name");
        }

        public int Run(int xang)
        {
            if (xang > 0)
            {
                return 10;
            }
            else
            {
                return 0;
            }

        }

    }
}
