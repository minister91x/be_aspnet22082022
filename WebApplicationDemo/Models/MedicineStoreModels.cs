using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using WebApplicationDemo.Models;

namespace WebApplicationDemo
{
    public partial class MedicineStoreModels : DbContext
    {
        public MedicineStoreModels()
            : base("name=MedicineStoreConnectionString")
        {
        }

        public virtual DbSet<BANHANG> BANHANGs { get; set; }
        public virtual DbSet<CUAHANG> CUAHANGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CUAHANG>()
                .Property(e => e.SĐT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SĐT)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
