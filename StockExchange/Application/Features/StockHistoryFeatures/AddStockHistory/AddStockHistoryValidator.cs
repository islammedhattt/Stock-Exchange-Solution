using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.StockHistoryFeatures.AddStockHistory
{
    public sealed class AddStockHistoryValidator : AbstractValidator<AddStockHistoryRequest>
    {
        public AddStockHistoryValidator() {
            RuleFor(x => x.Symbol).NotEmpty().WithMessage("StockHistorySymbolRequired");
            RuleFor(x => x.Price).NotEmpty().WithMessage("StockHistoryPriceRequired");
        }
    }
}
