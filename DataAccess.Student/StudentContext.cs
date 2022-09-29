using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess.Student
{
    public class StudentContext: DbContext
    {
        public StudentContext() : base("ManagerStudent")
        {
            var initializer = new MigrateDatabaseToLatestVersion<StudentContext, Migrations.Configuration>();
            Database.SetInitializer(initializer);
        }

        public virtual DbSet<DataAccess.Student.DAO.Student> student { get; set; }

    }
}
