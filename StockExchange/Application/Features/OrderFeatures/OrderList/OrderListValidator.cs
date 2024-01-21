using Application.Features.OrderFeatures.OrderList;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderFeatures.OrderList
{
    public sealed class GetUserValidator : AbstractValidator<OrderListRequest>
    {
        public GetUserValidator() {
        }
    }
}
