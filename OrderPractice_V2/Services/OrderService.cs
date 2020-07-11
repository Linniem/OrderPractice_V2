﻿using Microsoft.EntityFrameworkCore;
using OrderPractice_V2.Helpers;
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
        private readonly IOrderRepository repo;
        private readonly IViewModelConverter vmConverter;
        public OrderService(IOrderRepository orderRepository, IViewModelConverter vmConverter)
        {
            repo = orderRepository;
            this.vmConverter = vmConverter;
        }

        public async Task<IEnumerable<OrderVm>> GetAllOrderVmAsync()
        {
            var allOrders = await repo.GetAll().ToListAsync();
            return vmConverter.OrderConvertAll(allOrders);
        }
    }
}