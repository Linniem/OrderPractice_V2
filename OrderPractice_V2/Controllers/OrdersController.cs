using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrdersController(OrderPracticeContext context, IOrderService orderService)
        {
            this.orderService = orderService;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder()
        {
            return Ok(await orderService.GetAllOrderVmAsync());
        }

        [HttpPut("{orderId}")]
        public async Task<IActionResult> PutOrder(string orderId, OrderVm orderVm)
        {
            return Ok(await orderService.AddShipInfoAsync(orderVm));
        }
    }
}
