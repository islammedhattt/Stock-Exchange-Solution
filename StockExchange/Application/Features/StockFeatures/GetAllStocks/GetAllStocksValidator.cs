using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.StockFeatures.GetAllStocks
{
    public sealed class GetAllStocksValidator : AbstractValidator<GetAllStocksRequest>
    {
        public GetAllStocksValidator() {
        }
    }
}
