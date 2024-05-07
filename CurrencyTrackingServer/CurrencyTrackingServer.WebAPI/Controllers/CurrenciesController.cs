using CurrencyTrackingServer.Application.Features.Currencies.CreateCurrency;
using CurrencyTrackingServer.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyTrackingServer.WebAPI.Controllers;

[AllowAnonymous]
public class CurrenciesController :ApiController
{
    public CurrenciesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
