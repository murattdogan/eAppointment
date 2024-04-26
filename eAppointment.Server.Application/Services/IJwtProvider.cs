using eAppointment.Server.Domain.Entities;

namespace eAppointment.Server.Application.Services
{
    public interface IJwtProvider
    {
        Task<string> CreateTokenAsync(AppUser user);
    }
}
