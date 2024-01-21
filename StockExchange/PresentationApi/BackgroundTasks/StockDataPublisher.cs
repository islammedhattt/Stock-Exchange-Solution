using Application.Features.StockFeatures.GetAllStocks;
using Application.Features.StockHistoryFeatures.AddStockHistory;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace PresentationApi.BackgroundTasks
{
    public class StockDataPublisher : BackgroundService
    {
        private readonly IHubContext<RealTimeStockHub> _stockDataHubContext;
        private readonly IServiceProvider _serviceProvider;
        private readonly Random _randomGenerator;

        public StockDataPublisher(IHubContext<RealTimeStockHub> stockDataHubContext, IServiceProvider serviceProvider)
        {
            _stockDataHubContext = stockDataHubContext ?? throw new ArgumentNullException(nameof(stockDataHubContext));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _randomGenerator = new Random();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var StockService =
                      scope.ServiceProvider
                          .GetRequiredService<IMediator>();
                    var stocks = await StockService.Send(new GetAllStocksRequest());

                    UpdateStockPrices(stocks , StockService);
                    await PublishStockPrices(stocks);

                    await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                }
            }
        }

        private void UpdateStockPrices(List<GetAllStocksResponse> stocks , IMediator serviceProvider)
        {
            foreach (var stock in stocks)
            {
                stock.CurrentPrice = (Convert.ToDecimal(_randomGenerator.Next(30, 90)));
                AddStockHistoryRequest request = new AddStockHistoryRequest(Symbol: stock.Symbol,
                    Price: stock.CurrentPrice
                    );
                serviceProvider.Send(request);
            }
        }

        private async Task PublishStockPrices(List<GetAllStocksResponse> stocks)
        {
            await _stockDataHubContext.Clients.All.SendAsync("UpdateStockPrices", stocks);
        }
    }

}
