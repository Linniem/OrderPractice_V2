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
        {
            if (order == null)
            {
                return null;
            }
            return new OrderVm()
            {
                OrderId = order.OrderId,
                TotalPrice = order.TotalPrice,
                TotalCost = order.TotalCost,
                Status = order.OrderStatus,
            };
        }

        public static IEnumerable<ShipInfoVm> ConvertAllToViewModel(this List<ShipInfo> ShipInfoList)
            => from shipInfo in ShipInfoList
               select shipInfo.ConverterToViewModel();
        public static ShipInfoVm ConverterToViewModel(this ShipInfo shipInfo)
        {
            if (shipInfo == null)
            {
                return null;
            }
            return new ShipInfoVm()
            {
                CreatedDateTime = shipInfo.CreatedDateTime.ToString("yyyy/dd/MM HH:mm:ss"),
                ShipInfoId = shipInfo.ShipInfoId,
                ShipStatus = shipInfo.ShipStatus
            };
        }

        public static IEnumerable<OrderDetailVm> ConvertAllToViewModel(this List<OrderDetail> OrderDetailList)
            => from shipInfo in OrderDetailList
               select shipInfo.ConverterToViewModel();
        public static OrderDetailVm ConverterToViewModel(this OrderDetail orderDetail)
        {
            if (orderDetail == null)
            {
                return null;
            }
            return new OrderDetailVm()
            {
                OrderId = orderDetail.OrderId,
                UnitPrice = orderDetail.UnitPrice,
                UnitCost = orderDetail.UnitCost,
                Quantity = orderDetail.Quantity,
                ProductName = orderDetail.Product.ProductName
            };
        }

        public static IEnumerable<ProductVm> ConvertAllToViewModel(this List<Product> ProductlList)
            => from product in ProductlList
               select product.ConverterToViewModel();
        public static ProductVm ConverterToViewModel(this Product product)
        {
            if (product == null)
            {
                return null;
            }
            return new ProductVm()
            {
                UnitPrice = product.UnitPrice,
                ProductId = product.ProductId,
                ProductName = product.ProductName
            };
        }
    }
}
