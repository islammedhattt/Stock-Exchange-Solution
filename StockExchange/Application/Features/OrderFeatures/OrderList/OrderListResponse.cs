using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.Features.OrderFeatures.OrderList
{

    public sealed record OrderResponse
    {
        public Guid Id { get; set; }
        public string? Symbol { get; set; }
        public decimal? Price { get; set; }
        public OrderType? OrderType { get; set; }
        public int Quantity { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid? StockId { get; set; }
        public Stock? Stock { get; set; }
        public Guid UserId { get; set; } 


    }
}
