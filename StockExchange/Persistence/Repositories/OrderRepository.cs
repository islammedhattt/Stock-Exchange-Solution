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
    internal class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(DBContext context) : base(context)
        {
        }

        public async Task<List<Order>> GetAllOrdersByUser(Guid UserId)
        {
            return await Context.Orders.Where(O =>  O.UserId == UserId).ToListAsync();
        }
    }
}
