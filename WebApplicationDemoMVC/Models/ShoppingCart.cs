using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationDemoMVC.Models
{
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