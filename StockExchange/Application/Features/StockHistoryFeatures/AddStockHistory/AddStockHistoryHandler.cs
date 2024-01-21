using Application.Common.Repositories;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.StockHistoryFeatures.AddStockHistory
{
    public sealed class AddStockHistoryHandler : IRequestHandler<AddStockHistoryRequest, AddStockHistoryResponse>

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly  IStockHistoryRepository _StockHistoryRepository;
        private readonly IMapper _mapper;

        public AddStockHistoryHandler(IUnitOfWork unitOfWork, IStockHistoryRepository StockHistoryRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _StockHistoryRepository = StockHistoryRepository;
            _mapper = mapper;
        }

        public async Task<AddStockHistoryResponse> Handle(AddStockHistoryRequest request, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<StockHistory>(request);
            item.Timestamp = DateTime.Now;
            _StockHistoryRepository.Create(item);
            await _unitOfWork.Save(cancellationToken);
            return _mapper.Map<AddStockHistoryResponse>(item);
        }
    }
}
