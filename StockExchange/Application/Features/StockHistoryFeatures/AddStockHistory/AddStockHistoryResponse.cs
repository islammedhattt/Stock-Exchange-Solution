using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.Features.StockHistoryFeatures.AddStockHistory
{

    public sealed record AddStockHistoryResponse
    {
        public Guid Id { get; set; }
     
    }
}
