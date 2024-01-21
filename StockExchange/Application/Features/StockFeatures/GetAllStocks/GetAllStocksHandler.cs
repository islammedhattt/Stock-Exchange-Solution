using Application.Common.Repositories;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Application.Features.StockFeatures.GetAllStocks
{
    public sealed class GetAllStocksHandler : IRequestHandler<GetAllStocksRequest, List<GetAllStocksResponse>>

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly  IStockRepository _StockRepository;
        private readonly IMapper _mapper;

        public GetAllStocksHandler(IUnitOfWork unitOfWork, IStockRepository StockRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _StockRepository = StockRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllStocksResponse>> Handle(GetAllStocksRequest request, CancellationToken cancellationToken)
        {
            var StockList = await _StockRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllStocksResponse>>(StockList);
        }
    }
}
