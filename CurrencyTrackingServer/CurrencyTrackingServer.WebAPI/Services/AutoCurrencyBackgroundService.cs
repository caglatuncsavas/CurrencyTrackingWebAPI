using CurrencyTrackingServer.Application.Hubs;
using CurrencyTrackingServer.Domain.Entities;
using Microsoft.AspNetCore.SignalR;

namespace CurrencyTrackingServer.WebAPI.Services;

public class AutoCurrencyBackgroundService(IHubContext<TrackingHub> hubContext) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(1000);

            Random random = new();
            decimal amount = random.Next(31, 34);

            Currency currency = Currency.Create(amount, random.Next(1,3));

            await hubContext.Clients.All.SendAsync("Currency", currency);
        }
    }
}
