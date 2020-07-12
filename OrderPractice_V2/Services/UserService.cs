using OrderPractice_V2.Models;
using OrderPractice_V2.Repositories;
using OrderPractice_V2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderPractice_V2.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repo;
        public UserService(IUserRepository repo)
        {
            this.repo = repo;
        }

        public async Task<bool> ValidateUserAsync(LoginViewModel login)
        {
            var result = await repo.FindAsync
                (x => x.UserName == login.Username && x.Password == login.Password);
            return (result != null) ? true : false;
        }
    }
}
