using Microsoft.EntityFrameworkCore;
using OrderPractice_V2.Helpers;
using OrderPractice_V2.Models;
using OrderPractice_V2.Repositories;
using OrderPractice_V2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepo;
        private readonly IViewModelConverter vmConverter;
        private readonly IShipInfoRepository shipInfoRepo;
        public OrderService(IOrderRepository orderRepo,
            IViewModelConverter vmConverter,
            IShipInfoRepository shipInfoRepo)
        {
            this.orderRepo = orderRepo;
            this.vmConverter = vmConverter;
            this.shipInfoRepo = shipInfoRepo;
        }

        public async Task<IEnumerable<OrderVm>> GetAllOrderVmAsync()
        {
            var allOrders = await orderRepo.GetAll().ToListAsync();
            return vmConverter.ConvertAllGeneric(allOrders, 
                (Order x) => vmConverter.OrderConvertOne(x));
        }

        public async Task<OrderVm> AddShipInfoAsync(OrderVm orderVm)
        {
            var orderEntity = await orderRepo.GetAsync(orderVm.OrderId);
            var newShipInfoEntity = new ShipInfo()
            {
                OrderId = orderEntity.OrderId,
                CreatedDateTime = DateTime.Now,
                ShipInfoId = $"S{orderEntity.OrderId}",
                ShipStatus = "New"
            };
            orderEntity.OrderStatus = orderVm.Status;
            orderEntity.ShipInfoId = newShipInfoEntity.ShipInfoId;

            await orderRepo.UpdateAsync(orderEntity);
            await shipInfoRepo.CreateAynsc(newShipInfoEntity);
            return vmConverter.OrderConvertOne(orderEntity);
        }
    }
}
