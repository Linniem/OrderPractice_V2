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
        
        public IEnumerable<U> ConvertAllGeneric<T, U>(IEnumerable<T> modelList, Func<T, U> predicate)
        {
            foreach (var model in modelList)
            {
                yield return predicate.Invoke(model);
            }
        }

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

        public ShipInfoVm ShipInfoConvertOne(ShipInfo shipInfo)
        {
            return new ShipInfoVm()
            {
                OrderId = shipInfo.OrderId,
                CreatedDateTime = shipInfo.CreatedDateTime.ToString("yyyy/dd/MM HH:mm:ss"),
                ShipInfoId = shipInfo.ShipInfoId,
                ShipStatus = shipInfo.ShipStatus
            };
        }

    }
}
