using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Models
{
    public class ShipInfo
    {
        public string ShipInfoId { get; set; }
        public string ShipStatus { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public string OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
