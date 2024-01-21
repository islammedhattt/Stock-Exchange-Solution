﻿using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.Features.StockHistoryFeatures.GetAllStockHistory
{

    public sealed record GetAllStockHistoryResponse
    {
        public Guid Id { get; set; }
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
