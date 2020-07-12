using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderPractice_V2.Data;
using OrderPractice_V2.Models;
using OrderPractice_V2.Services;
using OrderPractice_V2.ViewModels;

namespace OrderPractice_V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        // GET: api/Products/{productName}
        [HttpGet("{productName}")]
        public async Task<ActionResult<ProductVm>> GetProduct(string productName)
        {
            return Ok(await productService.FindByProductNameAsync(productName));
        }

    }
}
