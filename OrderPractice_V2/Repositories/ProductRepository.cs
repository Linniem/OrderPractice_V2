using Microsoft.EntityFrameworkCore;
using OrderPractice_V2.Data;
using OrderPractice_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OrderPractice_V2.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly OrderPracticeContext dbContext;
        public ProductRepository(OrderPracticeContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Product> FindAsync(Expression<Func<Product, bool>> predicate)
        {
            return await dbContext.Products.Where(predicate).FirstOrDefaultAsync();
        }
    }
}

