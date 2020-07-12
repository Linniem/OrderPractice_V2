using OrderPractice_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Repositories
{
    public interface IOrderDetailRepository
    {
        public IQueryable<OrderDetail> GetAll();
    }
}
