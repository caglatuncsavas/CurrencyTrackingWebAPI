using CurrencyTrackingServer.Application.Hubs;
using CurrencyTrackingServer.Domain.Entities;
using CurrencyTrackingServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using TS.Result;

namespace CurrencyTrackingServer.Application.Features.Currencies.CreateCurrency;

internal sealed class CreateCurrencyCommandHandler(
    ICurrencyRepository currencyRepository,
    IHubContext<TrackingHub> hubContext,
    IUnitOfWork unitOfWork) : IRequestHandler<CreateCurrencyCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        Currency currency = Currency.Create(request.Amount, request.TypeValue);

        await currencyRepository.AddAsync(currency, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        await hubContext.Clients.All.SendAsync("Currency", currency);

        return "Create is successful";
    }
}
