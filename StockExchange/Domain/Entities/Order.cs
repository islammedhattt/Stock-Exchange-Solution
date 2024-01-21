using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public enum OrderType
    {
        Buy,
        Sell
    }

    public class Order : BaseEntity
    {
        public string? Symbol { get; set; }
        public OrderType? OrderType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid? StockId { get; set; }   
        public Stock? Stock { get; set; }    
        public Guid UserId { get; set; }
        public User? User { get; set; }

    }

}
