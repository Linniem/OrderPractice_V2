using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.ViewModels
{
    public class OrderVm
    {
        public string OrderId { get; set; }
        public int TotalPrice { get; set; }
        public int TotalCost { get; set; }
        public string Status { get; set; }
    }
}
