namespace WebAPI.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int DateOfBirth { get; set; }

        public int? grade_GradeId { get; set; }

        public virtual Grade Grade { get; set; }
    }
}
