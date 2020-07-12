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
    public class ProductService : IProductService
    {
        private readonly IProductRepository repo;
        public ProductService(IProductRepository repo)
        {
            this.repo = repo;
        }

        public async Task<ProductVm> FindByProductNameAsync(string productName)
        {
            var product = await repo.FindAsync(x => x.ProductName == productName);
            return product.ConverterToViewModel();
        }
    }
}
