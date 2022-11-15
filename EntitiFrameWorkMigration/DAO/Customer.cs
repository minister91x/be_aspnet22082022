using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration.DAO
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Category category { get; set; }
        public string ProductImage { get; set; }
        public int Price { get; set; }
        public int PriceSale { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public int IsHomePage { get; set; }
        public int Type { get; set; }
    }

    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string CatImg { get; set; }
        public string CatName { get; set; }
        public int ParentId { get; set; }
    }
}
