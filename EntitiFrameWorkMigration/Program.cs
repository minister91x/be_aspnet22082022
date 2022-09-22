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
            model.student.Add(new Student { Name = "Quang", Id = 11 });
            model.SaveChanges();
        }
    }
}
