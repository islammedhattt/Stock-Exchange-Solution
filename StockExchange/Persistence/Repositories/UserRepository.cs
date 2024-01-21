using Application.Common.Repositories;
using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Common;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DBContext context) : base(context)
        {
        }
        public async Task<User> GetUserByUsername(string Username)
        {
            return await Context.Users.Where(b => b.Username == Username).FirstAsync();
        }
    

    }
}
