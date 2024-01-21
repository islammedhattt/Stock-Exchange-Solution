using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.StockHistoryFeatures.AddStockHistory
{
    public sealed class AddStockHistoryMapper : Profile
    {
        public AddStockHistoryMapper()
        {
            CreateMap<AddStockHistoryRequest, StockHistory>();
            CreateMap<StockHistory, AddStockHistoryResponse>();
        }
    }
}
