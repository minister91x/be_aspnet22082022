using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    

    public class Items
    {
        public string type { get; set; }
        public string imageurl { get; set; }
        public string muatienmat { get; set; }
        public string muack { get; set; }
        public string bantienmat { get; set; }
        public string banck { get; set; }

    }
    public class Exchange
    {
        public List<Items> items { get; set; }

    }
}