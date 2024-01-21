using Application.Repositories;
using Domain.Entities;
using Persistance.Common;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class StockRepository : BaseRepository<Stock>, IStockRepository
    {
        public StockRepository(DBContext context) : base(context)
        {
        }
    }
}
