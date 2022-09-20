namespace WebApplicationDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [Key]
        public int MaNV { get; set; }

        [StringLength(50)]
        public string TenNV { get; set; }

        [StringLength(130)]
        public string DiaChi { get; set; }

        public int? Tuoi { get; set; }

        [StringLength(50)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string NhiemVu { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }
    }
}
