using Application.Common.Repositories;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.StockHistoryFeatures.GetAllStockHistory
{
    public sealed class GetAllStockHistoryHandler : IRequestHandler<GetAllStockHistoryRequest, List<GetAllStockHistoryResponse>>

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly  IStockHistoryRepository _StockHistoryRepository;
        private readonly IMapper _mapper;

        public GetAllStockHistoryHandler(IUnitOfWork unitOfWork, IStockHistoryRepository StockHistoryRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _StockHistoryRepository = StockHistoryRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllStockHistoryResponse>> Handle(GetAllStockHistoryRequest request, CancellationToken cancellationToken)
        {

            var list = await _StockHistoryRepository.GetHistoryBySympol(request.Sympol);
            return _mapper.Map<List<GetAllStockHistoryResponse>>(list);
        }
    }
}
