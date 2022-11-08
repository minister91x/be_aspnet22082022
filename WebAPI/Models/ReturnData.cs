using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ReturnData
    {
        public int Code { get; set; }
        public string Desc { get; set; }
    }

    public class StudentGetAllReturnData: ReturnData
    {
        public List<Student> lstPerson { get; set; }
    }

   
}