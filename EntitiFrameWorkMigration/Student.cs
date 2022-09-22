using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration
{
   
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
      //  public Grade grade { get; set; }
        public string Address { get; set; }

    }

    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
    }
}
