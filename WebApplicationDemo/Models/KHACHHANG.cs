namespace WebApplicationDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKH { get; set; }

        [StringLength(30)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(4)]
        public string GioiTinh { get; set; }

        public int? Tuoi { get; set; }

        [StringLength(15)]
        public string SĐT { get; set; }
    }
}
