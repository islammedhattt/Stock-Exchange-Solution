using Application.Features.StockFeatures.GetAllStocks;
using Application.Features.StockHistoryFeatures.AddStockHistory;
using Application.Features.StockHistoryFeatures.GetAllStockHistory;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationApi.Controllers.Stock
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StockController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[Authorize]
        //[HttpPost("AddStocksHistory")]

        //public async Task<ActionResult<AddStockHistoryResponse>> GetAllStocksHistory(AddStockHistoryRequest request)
        //{
        //    return await _mediator.Send(request);
        //}
        [HttpPost("GetAllStocksHistory")]

        public async Task<ActionResult<List<GetAllStockHistoryResponse>>> GetAllStocksHistory(GetAllStockHistoryRequest request)
        {
            return await _mediator.Send(request);
        }
        [Authorize]
        [HttpGet("GetAllStocks")]

        public async Task<ActionResult<List<GetAllStocksResponse>>> GetAllStocks()
        {
            return await _mediator.Send(new GetAllStocksRequest());
        }
    }
}
