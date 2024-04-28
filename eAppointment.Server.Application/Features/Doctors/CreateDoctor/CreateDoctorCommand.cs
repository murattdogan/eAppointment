using MediatR;
using TS.Result;

namespace eAppointment.Server.Application.Features.Doctors.CreateDoctor
{
    public sealed record CreateDoctorCommand(
    string FirstName,
    string LastName,
    int DepartmentValue) : IRequest<Result<string>>;
}
