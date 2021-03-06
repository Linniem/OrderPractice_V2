﻿using OrderPractice_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Repositories
{
    public interface IShipInfoRepository
    {
        IQueryable<ShipInfo> GetAll();
        public Task CreateAynsc(ShipInfo entity);
    }
}
