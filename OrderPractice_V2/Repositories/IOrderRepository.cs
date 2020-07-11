using OrderPractice_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Repositories
{
    public interface IOrderRepository
    {
        public IQueryable<Order> GetAll();
        public Task<Order> GetAsync(string id);
        public Task UpdateAsync(Order order);
    }
}
