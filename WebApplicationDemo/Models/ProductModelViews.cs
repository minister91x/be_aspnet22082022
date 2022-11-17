using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationDemo.Models
{
    public class ProductModelViews
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int Price { get; set; }
        public int PriceSale { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public int IsHomePage { get; set; }
        public int Type { get; set; }
    }

    public class ShoppingCart
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quality { get; set; }
        public int FeeShip { get; set; }
        public int CustomPrice { get; set; }
        public string Image { get; set; }

    }
}