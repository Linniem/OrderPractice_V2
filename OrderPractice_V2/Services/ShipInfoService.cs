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
        private readonly IViewModelConverter modelConverter;

        public ShipInfoService(IShipInfoRepository shipInfoRepo,IViewModelConverter modelConverter)
        {
            this.repo = shipInfoRepo;
            this.modelConverter = modelConverter;
        }

        public async Task<IEnumerable<ShipInfoVm>> GetAllShipInfoAsync()
        {
            var shipInfoList = await repo.GetAll().ToListAsync();
            return modelConverter.ConvertAllGeneric(shipInfoList,
                (ShipInfo x) => modelConverter.ShipInfoConvertOne(x));
        }
    }
}
