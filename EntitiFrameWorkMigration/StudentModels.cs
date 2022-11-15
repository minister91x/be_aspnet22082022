using EntitiFrameWorkMigration.DAO;
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
        public StudentModels() : base("ManagerStudent")
        {
          // Database.SetInitializer(new DropCreateDatabaseAlways<StudentModels>());

            var initializer = new MigrateDatabaseToLatestVersion<StudentModels, Migrations.Configuration>(); 
           Database.SetInitializer(initializer);
        }

        public virtual DbSet<Student> student { get; set; }

        public virtual DbSet<Customer> customer { get; set; }
        public virtual DbSet<Order> order { get; set; }
        public virtual DbSet<Grade> grade { get; set; }

        public virtual DbSet<Product> product { get; set; }

        public virtual DbSet<Category> category{get; set; }

    }
}
