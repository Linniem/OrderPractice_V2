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

namespace OrderPractice_V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailService odService;

        public OrderDetailsController(IOrderDetailService odService)
        {
            this.odService = odService;
        }

        // GET: api/OrderDetails/A20202026001
        [HttpGet("{orderId}")]
        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetOrderDetails(string orderId)
        {
            return Ok(await odService.GetManyByOrderIdAsync(orderId));
        }

    }
}
