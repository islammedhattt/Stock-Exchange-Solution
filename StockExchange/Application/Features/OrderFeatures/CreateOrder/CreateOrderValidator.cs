using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderFeatures.CreateOrder
{
    public sealed class CreateOrderValidator : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderValidator() {
        }
    }
}
