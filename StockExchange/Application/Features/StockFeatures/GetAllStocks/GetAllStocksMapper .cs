using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.StockFeatures.GetAllStocks
{
    public sealed class GetAllStocksMapper : Profile
    {
        public GetAllStocksMapper()
        {
            CreateMap<GetAllStocksRequest, Stock>();
            CreateMap<Stock, GetAllStocksResponse>();
        }
    }
}
