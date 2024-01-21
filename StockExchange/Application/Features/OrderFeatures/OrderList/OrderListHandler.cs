using Application.Common.Repositories;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.OrderFeatures.OrderList
{
    public sealed class OrderListHandler : IRequestHandler<OrderListRequest, List<OrderResponse>>

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly  IOrderRepository _OrderRepository;
        private readonly  IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public OrderListHandler(IUnitOfWork unitOfWork, IOrderRepository OrderRepository, IUserRepository userRepository ,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _OrderRepository = OrderRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<OrderResponse>> Handle(OrderListRequest request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByUsername(request.Username);
            var Orders = await _OrderRepository.GetAllOrdersByUser(user.Id);
            var res =  _mapper.Map<List<OrderResponse>>(Orders);
            return res;
        }
    }
}
