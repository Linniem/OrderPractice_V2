﻿using OrderPractice_V2.Models;
using OrderPractice_V2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Services
{
    public interface IProductService
    {
        public Task<ProductVm> FindByProductNameAsync(string productName);
    }
}
