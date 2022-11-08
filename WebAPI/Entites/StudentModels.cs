using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAPI.Entites
{
    public partial class StudentModels : DbContext
    {
        public StudentModels()
            : base("name=StudentModels")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Grade)
                .HasForeignKey(e => e.grade_GradeId);
        }
    }
}
