using eAppointment.Server.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAppointment.Server.Application.Features.Appointments.GetAllDoctorsByDepartment
{
    public sealed record GetAllDoctorsByDepartmentQuery(
    int DepartmentValue) : IRequest<Result<List<Doctor>>>;
}
