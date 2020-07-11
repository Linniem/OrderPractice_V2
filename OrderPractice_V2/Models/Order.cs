using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public int TotalPrice { get; set; }
        public int TotalCost { get; set; }
        public string OrderStatus { get; set; }

        public int UserId { get; set; }
        public string ShipInfoId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public IList<ShipInfo> ShipInfos { get; set; }
        public IList<OrderDetail> OrderDetails { get; set; }
    }
}
