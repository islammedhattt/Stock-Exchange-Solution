using Application.Common.Repositories;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.UserFeatures.GetUser
{
    public sealed class GetUserHandler : IRequestHandler<GetUserRequest, GetUserResponse>

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly  IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<User>(request);
            User user = await _userRepository.GetUserByUsername(item.Username!);
            return _mapper.Map<GetUserResponse>(user);
        }
    }
}
