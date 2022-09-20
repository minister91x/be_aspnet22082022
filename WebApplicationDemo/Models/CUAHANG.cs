namespace WebApplicationDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUAHANG")]
    public partial class CUAHANG
    {
        [Key]
        public int MaCH { get; set; }

        [Required]
        [StringLength(100)]
        public string TenCH { get; set; }

        [StringLength(100)]
        public string Diachi { get; set; }

        [StringLength(15)]
        public string SĐT { get; set; }
    }
}
