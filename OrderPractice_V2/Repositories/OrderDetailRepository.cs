using OrderPractice_V2.Data;
using OrderPractice_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly OrderPracticeContext dbContext;
        public OrderDetailRepository(OrderPracticeContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<OrderDetail> GetAll()
        {
            return dbContext.OrderDetails;
        }
    }
}
