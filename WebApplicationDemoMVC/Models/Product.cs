using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationDemoMVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ParentId { get; set; }
        public int CatID { get; set; }
        public int Price { get; set; }
        public int PriceSale { get; set; }
        public int FeeShip { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public int MetaKeyWord { get; set; }
        public int MetDescription { get; set; }
        public int IsActive { get; set; }
        public int CreateTime { get; set; }
        public int UserId { get; set; }
        public int Type { get; set; }
        public int SKU { get; set; }
        public int BrandName { get; set; }
        public int Capacity { get; set; }
        public int IsDisPlay { get; set; }
        public int Image { get; set; }
        public int seo_title { get; set; }
        public int seo_image { get; set; }
        public int ParentCateIds { get; set; }
        public int CateIds { get; set; }
        public int AliasName { get; set; }
        public int ProductWeight { get; set; }
        public int ProductLength { get; set; }
        public int ProductWidth { get; set; }
        public int ProductHeight { get; set; }
        public int UpdateTime { get; set; }
        public int IsHomePage { get; set; }
    }
}