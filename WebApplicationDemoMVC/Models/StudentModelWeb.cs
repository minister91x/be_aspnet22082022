using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationDemoMVC.Models
{
    public class StudentModelWeb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Grade grade { get; set; }
        public string Address { get; set; }
        public int DateOfBirth { get; set; }
    }
}