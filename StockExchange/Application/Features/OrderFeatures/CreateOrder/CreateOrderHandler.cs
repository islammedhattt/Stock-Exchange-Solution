using Application.Common.Repositories;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.OrderFeatures.CreateOrder
{
    public sealed class CreateOrderHandler : IRequestHandler<CreateOrderRequest, CreateOrderResponse>

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly  IOrderRepository _OrderRepository;
        private readonly  IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateOrderHandler(IUnitOfWork unitOfWork, IOrderRepository OrderRepository, IUserRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _OrderRepository = OrderRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<CreateOrderResponse> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            User user = await _userRepository.GetUserByUsername(request.Username);
            var item = _mapper.Map<Order>(request);
            item.User = user;
            _OrderRepository.Create(item);
            await _unitOfWork.Save(cancellationToken);
            return _mapper.Map<CreateOrderResponse>(item);
        }
    }
}
