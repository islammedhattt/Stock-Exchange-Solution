using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.StockHistoryFeatures.GetAllStockHistory
{
    public sealed class GetAllStockHistoryValidator : AbstractValidator<GetAllStockHistoryRequest>
    {
        public GetAllStockHistoryValidator() {
            RuleFor(x => x.Sympol).NotEmpty().WithMessage("StockHistoryNameRequired");
        }
    }
}
