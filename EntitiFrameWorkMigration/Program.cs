using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var model = new StudentModels();
            try
            {
                // model.grade.Add(new Grade { GradeName = "Toan11", GradeId = 1, Section = "abc" });
                var lstStudent = model.student.ToList();

                var student = model.student.ToList().FindAll(b => b.Id == 3).FirstOrDefault();

                if (student != null && student.Id > 0)
                {
                    student.Name = "QUẢNG NINH";
                    //model.student.Remove(student);
                    model.SaveChanges();
                }

                if (model.student.ToList().Count > 0)
                {
                    foreach (var item in model.student)
                    {
                        Console.WriteLine("Name :{0} - DateOfBirth :{1}", item.Name, item.DateOfBirth);
                    }
                }
                Console.WriteLine("-------------------------------------");

                // Cú pháp truy vấn
                var list = from item in model.student
                           where item.DateOfBirth == 1990
                           select item;
                Console.WriteLine("Cú pháp truy vấn");
                foreach (var item in list)
                {
                    Console.WriteLine("LINQ ID : {0} Name :{1} Address :{2}", item.Id, item.DateOfBirth, item.Address);
                }

                // Cú pháp phương thức

                var list1 = model.student
                    .Where(s => s.grade.GradeId > 1)
                    .OrderByDescending(s => s.Id);

                Console.WriteLine("Cú pháp phương thức");

                foreach (var item in list1)
                {

                    Console.WriteLine("LINQ ID : {0} Name :{1} Address :{2}"
                        , item.Id, item.DateOfBirth, item.Address);
                }

                var list1FirstOrDefault = model.student.FirstOrDefault();
                Console.WriteLine("LINQ FirstOrDefault ID : {0} Name :{1} Address :{2}",
                    list1FirstOrDefault.Id, list1FirstOrDefault.DateOfBirth, list1FirstOrDefault.Address);


            }
            catch (Exception ex)
            {

                throw ex;
            }

            Console.ReadLine();

        }
    }
}
