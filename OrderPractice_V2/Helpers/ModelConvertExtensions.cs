using OrderPractice_V2.Models;
using OrderPractice_V2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Helpers
{
    public static class ModelConvertExtensions
    {
        public static IEnumerable<OrderVm> ConvertAllToViewModel(this List<Order> OrderList)
            => from order in OrderList
               select order.ConverterToViewModel();
        public static OrderVm ConverterToViewModel(this Order order)
            => new OrderVm()
            {
                OrderId = order.OrderId,
                TotalPrice = order.TotalPrice,
                TotalCost = order.TotalCost,
                Status = order.OrderStatus,
            };

        public static IEnumerable<ShipInfoVm> ConvertAllToViewModel(this List<ShipInfo> ShipInfoList)
            => from shipInfo in ShipInfoList
               select shipInfo.ConverterToViewModel();
        public static ShipInfoVm ConverterToViewModel(this ShipInfo shipInfo)
            => new ShipInfoVm()
            {
                CreatedDateTime = shipInfo.CreatedDateTime.ToString("yyyy/dd/MM HH:mm:ss"),
                ShipInfoId = shipInfo.ShipInfoId,
                ShipStatus = shipInfo.ShipStatus
            };

        public static IEnumerable<OrderDetailVm> ConvertAllToViewModel(this List<OrderDetail> OrderDetailList)
            => from shipInfo in OrderDetailList
               select shipInfo.ConverterToViewModel();
        public static OrderDetailVm ConverterToViewModel(this OrderDetail orderDetail)
            => new OrderDetailVm()
            {
                OrderId = orderDetail.OrderId ,
                UnitPrice = orderDetail.UnitPrice ,
                UnitCost = orderDetail.UnitCost ,
                Quantity = orderDetail.Quantity,
                ProductName = orderDetail.Product.ProductName
            };

    }
}
