using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationDemoMVC.Models
{
    public class ReturnData
    {
        public int ReturnCode { get; set; }
        public string ReturnMessenger { get; set; }
    }

    public class ResponseData
    {
        public int ResponseCode { get; set; }
        public string Description { get; set; }
        public string Extend { get; set; }
    }
}