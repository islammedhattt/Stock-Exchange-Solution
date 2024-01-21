using Application.Common.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IUserRepository:IBaseRepository<User>
    {
        public Task<User> GetUserByUsername(string UserName);
    }
}
