using OrderPractice_V2.Data;
using OrderPractice_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Repositories
{
    public class ShipInfoRepository : IShipInfoRepository
    {
        private readonly OrderPracticeContext dbContext;
        public ShipInfoRepository(OrderPracticeContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<ShipInfo> GetAll()
        {
            return dbContext.ShipInfoes;
        }

        public async Task CreateAynsc(ShipInfo entity)
        {
            await dbContext.ShipInfoes.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
