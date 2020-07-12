using OrderPractice_V2.Models;
using OrderPractice_V2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Helpers
{
    public interface IViewModelConverter
    {
        public IEnumerable<OrderVm> OrderConvertAll(IEnumerable<Order> orderList);
        public OrderVm OrderConvertOne(Order order);
        public IEnumerable<ShipInfoVm> ShipInfoConvertAll(IEnumerable<ShipInfo> shipInfoList);
        public ShipInfoVm ShipInfoConvertOne(ShipInfo shipInfo);
    }
}
