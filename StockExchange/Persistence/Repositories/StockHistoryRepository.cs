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
    public class StockHistoryRepository : BaseRepository<StockHistory>, IStockHistoryRepository
    {
        public StockHistoryRepository(DBContext context) : base(context)
        {
        }
        public async Task<List<StockHistory>> GetHistoryBySympol(string Sympol)
        {
            return await Context.StockHistories.Where(b => b.Symbol == Sympol).ToListAsync();
        }
    }
}
