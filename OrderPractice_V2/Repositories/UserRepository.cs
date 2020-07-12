using Microsoft.EntityFrameworkCore;
using OrderPractice_V2.Data;
using OrderPractice_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OrderPractice_V2.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly OrderPracticeContext dbContext;
        public UserRepository(OrderPracticeContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<User> FindAsync(Expression<Func<User, bool>> predicate)
        {
            return await dbContext.Users.Where(predicate).FirstOrDefaultAsync();
        }
    }
}
