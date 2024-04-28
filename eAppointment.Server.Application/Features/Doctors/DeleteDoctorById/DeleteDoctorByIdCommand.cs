using MediatR;
using TS.Result;

namespace eAppointment.Server.Application.Features.Doctors.DeleteDoctorById
{
    public sealed record DeleteDoctorByIdCommand(
    Guid Id) : IRequest<Result<string>>;
}
