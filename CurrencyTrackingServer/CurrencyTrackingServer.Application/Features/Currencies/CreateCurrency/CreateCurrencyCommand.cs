using MediatR;
using TS.Result;

namespace CurrencyTrackingServer.Application.Features.Currencies.CreateCurrency;
public sealed record CreateCurrencyCommand(
     int TypeValue,
     decimal Amount ) : IRequest<Result<string>>;
