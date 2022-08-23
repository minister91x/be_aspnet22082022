using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;
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


        public static void UserInput(string s)
        {
            if (s.Length > 10)
            {
                Exception e = new DataTooLongExeption();
                throw e;    // lỗi văng ra
            }
            //Other code - no exeption
        }

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
            //var i2 = 10.2;

            //var i1 = 10;

            //var y = "my name";

            //var lst1 = lst;

            //// Hằng số 
            //const int myConst = 10;

            //int number1 = 20;
            //int number2 = 30;

            //int number3 = number1 + number2;
            //int number4 = number1 - number2;
            //Console.WriteLine("number1 = {0} + number2 = {1} la :{2}", number1, number2, number3);
            //Console.WriteLine("number1 = {0} - number2 = {1} la :{2}", number1, number2, number4);

            //if (number1 <= number2)
            //{
            //    Console.WriteLine("number1 = number2");
            //}
            //else
            //{
            //    Console.WriteLine("number1 khac number2");
            //}




            //----------------------------------------------------------------

            //var pstruct = new Product("Iphone14", 250000, 1);
            //var statusNme = pstruct.GetProductStatusName(1);

            //Console.WriteLine("Name :{0} Status: {1} StatusName {2}", pstruct.Name, statusNme, statusNme);


            //-------------------------------------------------


            //string[] cars = { "Honda", "BMW", "Ford", "Mazda" };

            //string[] number = { "1", "2", "3" };

            //Console.WriteLine("do dai cua mang {0}", cars.Length);
            //Console.WriteLine("gia tri ơ vi tri thu 1 {0}", cars[1]);
            //cars[4] = "Mercedes G63";

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine("vi tri thu {0} - gia tri {1}", i, cars[i]);
            //}

            //áp dụng cho các mảng hoặc là các list object chưa biết trước độ dài
            //foreach (string car in cars)
            //{
            //    Console.WriteLine("gia tri {0}", car);
            //}

            //Bôi đen đoạn cần comment rồi nhấn CTRL+K + C
            // Mở comment : CTRL + K + U



            //Array.Sort(cars);

            //Array.Reverse(cars);

            //foreach (string car in cars)
            //{
            //    Console.WriteLine("gia tri {0}", car);
            //}

            //var indexof = Array.IndexOf(cars, "BMW");

            //Console.WriteLine("vi tri cua BMW la {0}", cars[4]);




            //int[] arr1 = new int[100];
            //int[] fr1 = new int[100];
            //int n, i, j, bien_dem;


            //Console.Write("\nDem so lan xuat hien cua tung phan tu trong mang trong C#:\n");
            //Console.Write("-----------------------------------------------------------\n");

            //Console.Write("Nhap so phan tu can luu giu trong mang: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("Phan tu - {0}: ", i);
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //    fr1[i] = -1;
            //}
            //for (i = 0; i < n; i++)
            //{
            //    bien_dem = 1;
            //    for (j = i + 1; j < n; j++)
            //    {
            //        if (arr1[i] == arr1[j])
            //        {
            //            bien_dem++;
            //            fr1[j] = 0;
            //        }
            //    }

            //    if (fr1[i] != 0)
            //    {
            //        fr1[i] = bien_dem;
            //    }
            //}
            //Console.Write("\nTan suat xuat hien cua tung phan tu trong mang la: \n");
            //for (i = 0; i < n; i++)
            //{
            //    if (fr1[i] != 0)
            //    {
            //        Console.Write("Phan tu {0} xuat hien {1} lan\n", arr1[i], fr1[i]);
            //    }
            //}

            //int n, i, j, tmp;
            //int[] myNum = { 1, 4, 8, 5, 10 };

            //for (i = 0; i < myNum.Length; i++)
            //{
            //    for (j = i + 1; j < myNum.Length; j++)
            //    {
            //        if (myNum[j] > myNum[i])
            //        {
            //            //cach trao doi gia tri
            //            tmp = myNum[i];
            //            myNum[i] = myNum[j];
            //            myNum[j] = tmp;
            //        }
            //    }
            //}

            /// chiều giảm dần
            /// 10 8 5 4 1
            //  Console.Write("Phan tu lon thu 2 la {1}", myNum[1]);
            //  -----------------------------------------------------------
            int a = 10;

            //var myfunc2 = new MyFunction12();
            //myfunc2.MF2_CongHaiSo(100);


            //var myfunc = new MyFunction1();
            //myfunc.MF_CongHaiSo(a);
            //Console.Write("MF_CongHaiSo tham tri {0} \n", a);


            //myfunc.MF_CongHaiSoThamChieu(ref a);
            //Console.Write("MF_CongHaiSo tham chieu dung REF {0} \n", a);

            //int tich;
            //myfunc.MF_CongHaiSoThamChieu_Out(out tich);

            //Console.Write("MF_CongHaiSo tham chieu dung OUT {0} \n", tich);

            try
            {
                UserInput("Đây là một chuỗi rất dài ...");
            }
            catch (DataTooLongExeption e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception otherExeption)
            {
                Console.WriteLine(otherExeption.Message);
            }


            //var minvalue = DateTime.MinValue;
            //var maxValue = DateTime.MaxValue;

            //var newDate = new DateTime(2022, 8, 23);
            //var newDateHour = new DateTime(2022, 8, 23, 19, 20, 59);


            //DateTime aDateTime = DateTime.Now;
            //Console.WriteLine("Now is " + aDateTime);

            //// Một khoảng thời gian. 
            //// 1 giờ + 1 phút
            //var aInterval = new System.TimeSpan(-30, 1, 1, 0);

            //// Thêm một khoảng thời gian.
            //DateTime newTime = aDateTime.Add(aInterval);

            //DateTime newTime1 = aDateTime.AddDays(0).AddHours(1).AddMinutes(1);

            //Console.WriteLine("298 :newTime: " + newTime);

            //DateTime newTime12 = aDateTime.AddHours(30);

            //Console.WriteLine("befor 30 days: " + newTime);

            //DateTime newTimeaddHour = aDateTime.AddHours(-2);
            //Console.WriteLine("befor add 2 hour: " + newTimeaddHour);

            //DateTime newTimeaddMinutes = aDateTime.AddMinutes(30);
            //Console.WriteLine("After add 30 minutes: " + newTimeaddHour);

            //// Trừ khoảng thời gian.
            //newTime = aDateTime.Subtract(aInterval);

            //int maxdayinMonth = DateTime.DaysInMonth(2022, 02);
            //Console.WriteLine("Max day cua thang 2: " + maxdayinMonth);

            //DateTime aDateTime12 = new DateTime(2022, 8, 22, 19, 30, 00);
            //// Các định dạng date-time được hỗ trợ.
            //string[] formattedStrings = aDateTime12.GetDateTimeFormats();

            //foreach (string format in formattedStrings)
            //{
            //    Console.WriteLine(format);
            //}


            //DateTime aDateTimes = new DateTime(2022, 8, 22, 19, 30, 00);

            //Console.WriteLine(aDateTimes.ToString("dd/MM/yyyy HH:mm:ss"));

            //Console.WriteLine(aDateTimes.ToString("yyyy/MM/dd HH:mm:ss"));

            //Console.WriteLine(aDateTimes.ToString("HH:mm:ss dd/MM/yyyy"));

            string createDateString = "22/08/2022 19:30:00";


            var newDateConvert = DateTime.ParseExact(createDateString, "dd/MM/yyyy HH:mm:ss",
                CultureInfo.InvariantCulture);

            //var convert = Convert.ToDateTime(createDateString);

            Console.WriteLine("newDateConvert: " + newDateConvert);


            //DateTime dateValue;
            //if (!DateTime.TryParseExact(createDateString, "dd/MM/yyyy HH:mm:ss",
            //    new CultureInfo("en-US"), DateTimeStyles.None, out dateValue))
            //{
            //    Console.WriteLine("Khong phai dinh dang ngay thang");
            //}
            //else
            //{
            //    Console.WriteLine("Dung la dinh dang ngay thang");
            //}


            string demoString = "Demo_String,";
            Console.WriteLine("chuoi ban dau {0}", demoString);
            var value = demoString.Split('_')[1];
            Console.WriteLine("chuoi sau khi cat {0}", value);
            //demoString.Split('_').Length;

            var replaceValue = demoString.Replace("Demo", "Demo1");
            Console.WriteLine("chuoi sau khi Replace {0}", replaceValue);

            var substringValue = demoString.Substring(0, demoString.Length - 1);
            Console.WriteLine("chuoi sau khi substringValue {0}", substringValue);


            string Value = "MyName";
            Value = Value + "Is Quan";

            StringBuilder MutableValue = new StringBuilder("MyName");
            MutableValue.Append("Is Quan");

           var abac = Console.ReadLine();

            if(abac== demoString)
            {

            }
        }

        static void myFunction(int inputNumber)
        {
            myName = "My Name2";
        }
    }
}
