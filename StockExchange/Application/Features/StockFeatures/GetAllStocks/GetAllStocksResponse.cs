using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.Features.StockFeatures.GetAllStocks
{

    public sealed record GetAllStocksResponse
    {
        public Guid Id { get; set; }
        public string Symbol { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
