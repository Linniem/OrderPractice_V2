using OrderPractice_V2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly OrderDetailRepository odRepo;
        public OrderDetailService(OrderDetailRepository odRepo)
        {
            this.odRepo = odRepo;
        }

        public void Test()
        {
            var a = 1;
            a += 1;
        }
    }
}
