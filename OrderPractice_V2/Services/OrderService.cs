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
        private readonly IShipInfoRepository shipInfoRepo;
        public OrderService(IOrderRepository orderRepo,
            IShipInfoRepository shipInfoRepo)
        {
            this.orderRepo = orderRepo;
            this.shipInfoRepo = shipInfoRepo;
        }

        public async Task<IEnumerable<OrderVm>> GetAllOrderVmAsync()
        {
            var orderList = await orderRepo.GetAll().ToListAsync();
            return orderList.ConvertAllToViewModel();
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
            return orderEntity.ConverterToViewModel();
        }
    }
}
