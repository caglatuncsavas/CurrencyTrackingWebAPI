using CurrencyTrackingServer.Application.Features.Auth.Login;
using CurrencyTrackingServer.Domain.Entities;

namespace CurrencyTrackingServer.Application.Services;
public interface IJwtProvider
{
    Task<LoginCommandResponse> CreateToken(AppUser user);
}
