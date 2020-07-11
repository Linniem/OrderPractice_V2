using OrderPractice_V2.Models;
using OrderPractice_V2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Helpers
{
    public class ViewModelConverter : IViewModelConverter
    {
        public OrderVm OrderConvertOne(Order order)
        {
            return new OrderVm()
            {
                OrderId = order.OrderId,
                TotalPrice = order.TotalPrice,
                TotalCost = order.TotalCost,
                Status = order.OrderStatus,
            };
        }

        public IEnumerable<OrderVm> OrderConvertAll(IEnumerable<Order> orderList)
        {
            foreach (var order in orderList)
            {
                yield return OrderConvertOne(order);
            }
        }
    }
}
