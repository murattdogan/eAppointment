using eAppointment.Server.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAppointment.Server.Application.Features.Doctors.GetAllDoctor
{
    public sealed record GetAllDoctorsQuery() :IRequest<Result<List<Doctor>>>
    {
    }
}
