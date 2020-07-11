using OrderPractice_V2.Models;
using OrderPractice_V2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Services
{
    public interface IOrderService
    {
        public Task<IEnumerable<OrderVm>> GetAllOrderVmAsync();
        public Task<OrderVm> UpdateEntityAsync(OrderVm orderVm);
    }
}
