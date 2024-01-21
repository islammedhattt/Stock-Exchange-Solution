using Application.Common.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IStockHistoryRepository : IBaseRepository<StockHistory>
    {
        Task<List<StockHistory>> GetHistoryBySympol(string Sympol);

    }
}
