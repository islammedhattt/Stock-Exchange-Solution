using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Domain.Entities;

namespace Application.Features.OrderFeatures.CreateOrder
{

    public sealed record CreateOrderRequest(
        string? Username,
      string? Symbol,
      decimal? Price,
      OrderType? OrderType,
      int? Quantity) : IRequest<CreateOrderResponse>;


    /*
     * 
     *    public string? Symbol { get; set; }
        public OrderType? OrderType { get; set; }
        public int Quantity { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid? StockId { get; set; }   
        public Stock? Stock { get; set; }    
        public Guid UserId { get; set; } // Assuming UserId is a string, adjust as necessary
     */

}
