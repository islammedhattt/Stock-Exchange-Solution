using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Application.Features.OrderFeatures.OrderList;

namespace Application.Features.OrderFeatures.OrderList
{

    public sealed record OrderListRequest(
      string Username
   ) : IRequest<List<OrderResponse>>;


}
