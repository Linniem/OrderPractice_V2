using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.ViewModels
{
    public class ShipInfoVm
    {
        public string ShipInfoId { get; set; }
        public string OrderId { get; set; }
        public string ShipStatus { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
