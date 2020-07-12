using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.ViewModels
{
    public class OrderDetailVm
    {
        public string OrderId { get; set; }
        public int UnitPrice { get; set; }
        public int UnitCost { get; set; }
        public int Quantity { get; set; }

        public string ProductName { get; set; }
    }
}
