using eAppointment.Server.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAppointment.Server.Application.Features.Appointments.GetPatientByIdentityNumber
{
    public sealed record GetPatientByIdentityNumberQuery(
     string IdentityNumber) : IRequest<Result<Patient>>;
}
