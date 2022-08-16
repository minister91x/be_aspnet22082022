using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Program
    {
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
            Console.ReadLine();
        }

        static void myFunction(int inputNumber)
        {
            myName = "My Name2";
        }
    }
}
