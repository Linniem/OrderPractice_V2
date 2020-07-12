using OrderPractice_V2.Data;
using OrderPractice_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OrderPractice_V2.Repositories
{
    public interface IUserRepository
    {
        public Task<User> FindAsync(Expression<Func<User, bool>> predicate);
    }
}
