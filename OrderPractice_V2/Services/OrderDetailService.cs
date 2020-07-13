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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository repo;
        public OrderDetailService(IOrderDetailRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<OrderDetailVm>> GetManyByOrderIdAsync(string orderId)
        {
            var OrderDetailVmList = await repo.GetAll()
                .Include("Product")
                .Where(x => x.OrderId == orderId)
                .ToListAsync();
            return OrderDetailVmList.ConvertAllToViewModel();
        }
    }
}
