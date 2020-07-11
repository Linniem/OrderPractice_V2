using Microsoft.EntityFrameworkCore;
using OrderPractice_V2.Data;
using OrderPractice_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderPracticeContext dbContext;
        public OrderRepository(OrderPracticeContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<Order> GetAll()
        {
            return dbContext.Orders;
        }

        public async Task<Order> GetAsync(string id)
        {
            return await dbContext.Orders
                .FirstOrDefaultAsync(x => x.OrderId == id);
        }

        public async Task UpdateAsync(Order order)
        {
            dbContext.Entry(order).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }
    }
}
