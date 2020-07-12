using Microsoft.EntityFrameworkCore;
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
    public class ShipInfoService : IShipInfoService
    {
        private readonly IShipInfoRepository repo;

        public ShipInfoService(IShipInfoRepository shipInfoRepo)
        {
            this.repo = shipInfoRepo;
        }

        public async Task<IEnumerable<ShipInfoVm>> GetAllShipInfoAsync()
        {
            var ShipInfoList = await repo.GetAll().ToListAsync();
            return ShipInfoList.ConvertAllToViewModel();
        }
    }
}
