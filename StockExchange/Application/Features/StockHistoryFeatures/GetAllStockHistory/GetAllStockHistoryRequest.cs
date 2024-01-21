using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Domain.Entities;

namespace Application.Features.StockHistoryFeatures.GetAllStockHistory
{

    public sealed record GetAllStockHistoryRequest(
      string? Sympol
   ) : IRequest<List<GetAllStockHistoryResponse>>;


}
