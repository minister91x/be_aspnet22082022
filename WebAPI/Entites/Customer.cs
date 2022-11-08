namespace WebAPI.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
