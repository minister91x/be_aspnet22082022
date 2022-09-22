namespace WebApplicationDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    //using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSP { get; set; }

        [StringLength(10)]
        public string TenSP { get; set; }

        [StringLength(20)]
        public string CongDung { get; set; }

        [StringLength(10)]
        public string Loai { get; set; }
    }
}
