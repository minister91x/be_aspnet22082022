using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationDemoMVC.Models
{
    public class Category
    {
        public int CatId { get; set; }
        public string CatImg { get; set; }
        public string CatName { get; set; }
        public int ParentId { get; set; }
    }
}