using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration
{
    public class StudentModels : DbContext
    {
        public StudentModels() : base("name=ManagerStudent")
        {
           Database.SetInitializer(new DropCreateDatabaseAlways<StudentModels>());

            //var initializer = new MigrateDatabaseToLatestVersion<StudentModels, Migrations.Configuration>(); 
            //Database.SetInitializer(initializer);
        }

        public virtual DbSet<Student> student { get; set; }

        //public virtual DbSet<Grade> grade { get; set; }
    }
}
