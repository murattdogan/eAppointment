using MediatR;
using TS.Result;

namespace eAppointment.Server.Application.Features.Roles.RoleSync
{
    public sealed record RoleSyncCommand() : IRequest<Result<string>>;
}
