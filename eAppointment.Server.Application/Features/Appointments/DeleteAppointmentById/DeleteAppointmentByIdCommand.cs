using MediatR;
using TS.Result;

namespace eAppointment.Server.Application.Features.Appointments.DeleteAppointmentById
{
    public sealed record DeleteAppointmentByIdCommand(
     Guid Id) : IRequest<Result<string>>;
}
