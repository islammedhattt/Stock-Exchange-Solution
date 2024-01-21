using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.Features.OrderFeatures.CreateOrder
{

    public sealed record CreateOrderResponse
    {
        public Guid Id { get; set; }
        public string? Symbol { get; set; }
        public OrderType? OrderType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
