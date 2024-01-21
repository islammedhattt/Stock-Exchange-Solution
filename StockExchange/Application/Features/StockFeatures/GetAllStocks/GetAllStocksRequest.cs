using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Domain.Entities;

namespace Application.Features.StockFeatures.GetAllStocks
{

    public sealed record GetAllStocksRequest(
  ) : IRequest<List<GetAllStocksResponse>>;


}
