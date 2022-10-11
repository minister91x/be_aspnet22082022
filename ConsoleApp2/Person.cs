using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
       /// <summary>
       /// chú thích
       /// </summary>
          public string Name { get; set; }
        /// <summary>
        /// biểu diễn địa chỉ của 1 người
        /// </summary>
        public string address { get; set; }

        public decimal ProductCosIn { get; set; }
        public decimal ProductCosOut { get { return ProductCosIn * Convert.ToDecimal(1.5); } }
    }
}
