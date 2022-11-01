using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration.DAO
{
    public class Order
    {
        public int Id { get; set; }
        public string MaDH { get; set; }
        public double TotalAmount { get; set; }
    }
}
