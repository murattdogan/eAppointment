using eAppointment.Server.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAppointment.Server.Application.Features.Users.GetAllRolesForUsers
{
    public sealed record GetAllRolesForUsersQuery() : IRequest<Result<List<AppRole>>>;
}
