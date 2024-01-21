using Application.Features.StockFeatures.GetAllStocks;
using Domain.Entities;
using Microsoft.AspNetCore.SignalR;

namespace PresentationApi.BackgroundTasks
{
    public class RealTimeStockHub : Hub
    {
        public async Task BroadcastStockPrices(List<GetAllStocksResponse> stocks)
        {
            await Clients.All.SendAsync("UpdateRealTimeStockPrices", stocks);
        }
    }
}
