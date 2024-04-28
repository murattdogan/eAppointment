using eAppointment.Server.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace eAppointment.Server.Application.Features.Patients.GetAllPatients
{
    public sealed record GetAllPatientsQuery() : IRequest<Result<List<Patient>>>;
}
