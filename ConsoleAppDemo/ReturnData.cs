using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class ReturnData
    {
        public int ReturnCode { get; set; }
        public string ReturnMsg { get; set; }
    }

    public class Insert : ReturnData
    {
        public int ID { get; set; }
        public int Name { get; set; }
    }

    public class Getlist : ReturnData
    {
        public int TotalCount { get; set; }
    }

    public class Update : ReturnData
    {
        public int ID { get; set; }
    }

    public class Delete : ReturnData
    {
        public int ID { get; set; }
    }
}
