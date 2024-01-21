using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Domain.Entities;

namespace Application.Features.StockHistoryFeatures.AddStockHistory
{

    public sealed record AddStockHistoryRequest(
      string Symbol,
      decimal Price) : IRequest<AddStockHistoryResponse>;

  
}
