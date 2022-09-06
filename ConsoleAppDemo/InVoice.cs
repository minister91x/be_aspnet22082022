using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class InVoice
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }

        public int TotalAmount { get; set; }
    }
}
