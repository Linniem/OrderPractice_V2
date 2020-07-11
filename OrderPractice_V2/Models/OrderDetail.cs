using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Models
{
    public class OrderDetail
    {
        // composite key set in Context
        public string OrderId { get; set; }
        public int ProductId { get; set; }

        public int UnitPrice { get; set; }
        public int UnitCost { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
