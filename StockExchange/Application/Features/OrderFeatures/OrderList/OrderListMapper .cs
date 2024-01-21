using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderFeatures.OrderList
{
    public sealed class OrderListMapper : Profile
    {
        public OrderListMapper()
        {
            CreateMap<OrderListRequest, Order>();
            CreateMap<Order, OrderResponse>();
        }
    }
}
