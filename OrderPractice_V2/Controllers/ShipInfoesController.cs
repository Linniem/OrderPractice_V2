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
    public class ShipInfoesController : ControllerBase
    {
        private readonly IShipInfoService shipInfoService;

        public ShipInfoesController(IShipInfoService shipInfoService)
        {
            this.shipInfoService = shipInfoService;
        }

        // GET: api/ShipInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShipInfoVm>>> GetShipInfos()
        {
            return Ok(await shipInfoService.GetAllShipInfoAsync());
        }
    }
}
