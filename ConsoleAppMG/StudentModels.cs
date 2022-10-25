using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMG
{
    public class StudentModels : DbContext
    {
        public StudentModels() : base("ManagerStudent")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<StudentModels>());
        }
        public virtual DbSet<Student> student { get; set; }
    }
}
