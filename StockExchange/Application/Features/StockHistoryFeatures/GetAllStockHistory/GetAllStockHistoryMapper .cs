using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.StockHistoryFeatures.GetAllStockHistory
{
    public sealed class GetAllStockHistoryMapper : Profile
    {
        public GetAllStockHistoryMapper()
        {
            CreateMap<GetAllStockHistoryRequest, StockHistory>();
            CreateMap<StockHistory, GetAllStockHistoryResponse>();
        }
    }
}
