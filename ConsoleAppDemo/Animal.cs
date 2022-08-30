using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
   public abstract class Animal
    { 
        // có thể khai báo được thuộc tính
        public string Name { get; set; }

        // có thể có thân hàm hoặc không
        public abstract void AnimalSound();

        // virtual method
        public void Eat()
        {
            Console.WriteLine("Động vật ăn cỏ");
        }
    }
}
