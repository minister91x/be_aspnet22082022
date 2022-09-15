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

        // abstract method KHÔNG được có thân hàm và phương thức chỉ có tên ở lớp cơ sở(base class) 
        // BẮT BUỘC phải được override ở tất các các lớp kế thừa(derived class).
        public abstract void AnimalSound();

        // virtual method BẮT BUỘC phải có thân hàm 
        // KHÔNG BẮT BUỘC phải override ở các class con kế thừa
        public virtual void Eat()
        {
            Console.WriteLine("Động vật ăn cỏ");
        }
    }
}
