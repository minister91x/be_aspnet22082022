using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Program
    {
      
        public struct Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }

            public int Status { get; set; }
            public Product(string name, double price, int status)
            {
                Name = name;
                Price = price;
                Description = name + " " + price;
                Status = status;
            }

            public string PriceToString()
            {
                return Price + " VND";
            }

            public string GetProductStatusName(int status)
            {
                string StatusName = "";
                //if (status == (int)ProductStatus.HangMoi)
                //{
                //    StatusName = "Iphone chưa qua sử dụng";
                //}

                if (status == Convert.ToInt32(ProductStatus.HangMoi))
                {
                    StatusName = "Iphone chưa qua sử dụng";
                }


                if (status == (int)ProductStatus.HangDaSudung)
                {
                    StatusName = "Iphone chưa đã sử dụng";
                }

                return StatusName;
            }
        }

        enum myEnum
        {
            CholayHang = 0,
            DaLayHang = 1,
            DangGiaoHang = 2,
            Dagiao = 3
        }

        enum ProductStatus
        {
            HangMoi = 1,
            HangDaSudung = 2

        }

        static string myName = "";
        static void Main(string[] args)
        {

            string myName1 = "My name is Quan", myDescription = "myDescription";

            string BAC = "abc";
            //var lst= new List<string>();
            //try
            //{
            //    string name = lst[1];
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
            myName = "My Name1";
            myName1 = "My name111";

            List<string> lst = new List<string>();
            var i2 = 10.2;

            var i1 = 10;

            var y = "my name";

            var lst1 = lst;

            // Hằng số 
            const int myConst = 10;

            int number1 = 20;
            int number2 = 30;

            int number3 = number1 + number2;
            int number4 = number1 - number2;
            Console.WriteLine("number1 = {0} + number2 = {1} la :{2}", number1, number2, number3);
            Console.WriteLine("number1 = {0} - number2 = {1} la :{2}", number1, number2, number4);

            if (number1 <= number2)
            {
                Console.WriteLine("number1 = number2");
            }
            else
            {
                Console.WriteLine("number1 khac number2");
            }


            for (int i = 2; i <= 10; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.WriteLine("{0} ", i);
                }
            }


            //----------------------------------------------------------------

            //var pstruct = new Product("Iphone14", 250000, 1);
            //var statusNme = pstruct.GetProductStatusName(1);

            //Console.WriteLine("Name :{0} Status: {1} StatusName {2}", pstruct.Name, statusNme, statusNme);


            //-------------------------------------------------


            string[] cars = { "Honda", "BMW", "Ford", "Mazda" };

            string[] number = { "1", "2", "3" };

            //Console.WriteLine("do dai cua mang {0}", cars.Length);
            //Console.WriteLine("gia tri ơ vi tri thu 1 {0}", cars[1]);
            //cars[4] = "Mercedes G63";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("vi tri thu {0} - gia tri {1}", i, cars[i]);
            }

            //áp dụng cho các mảng hoặc là các list object chưa biết trước độ dài
            foreach (string car in cars)
            {
                Console.WriteLine("gia tri {0}", car);
            }

            //Bôi đen đoạn cần comment rồi nhấn CTRL+K + C
            // Mở comment : CTRL + K + U



            Array.Sort(cars);

            Array.Reverse(cars);

            foreach (string car in cars)
            {
                Console.WriteLine("gia tri {0}", car);
            }

            var indexof = Array.IndexOf(cars, "BMW");

            Console.WriteLine("vi tri cua BMW la {0}", cars[4]);


            Console.ReadLine();
        }

        static void myFunction(int inputNumber)
        {
            myName = "My Name2";
        }
    }
}
