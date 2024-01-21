using Application.Features.OrderFeatures.CreateOrder;
using Application.Features.OrderFeatures.OrderList;
using Application.Features.StockHistoryFeatures.GetAllStockHistory;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationApi.Controllers.Order
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Authorize]
        [HttpPost("OrderList")]

        public async Task<ActionResult<List<OrderResponse>>> OrderList(OrderListRequest request)
        {
            OrderListRequest newRequest = new OrderListRequest(Username: User.Identity.Name
                );
            return await _mediator.Send(newRequest);
        }
        [Authorize]
        [HttpPost("CreateOrder")]

        public async Task<ActionResult<CreateOrderResponse>> CreateOrder(CreateOrderRequest request)
        {
            CreateOrderRequest newRequest = new CreateOrderRequest(Username: User.Identity.Name,
                Symbol: request.Symbol,
                Price: request.Price,
                OrderType:OrderType.Buy,
                Quantity:request.Quantity
                );
            return await _mediator.Send(newRequest);
        }
    }
}
