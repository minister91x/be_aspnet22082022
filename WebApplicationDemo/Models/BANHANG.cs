namespace WebApplicationDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANHANG")]
    public partial class BANHANG
    {
        public int ID { get; set; }

        public int? MaKH { get; set; }

        public int? MaNV { get; set; }

        public int? MaSP { get; set; }

        public int? Soluong { get; set; }
    }
}
