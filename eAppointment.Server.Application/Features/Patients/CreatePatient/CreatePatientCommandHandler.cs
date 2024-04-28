﻿using AutoMapper;
using eAppointment.Server.Domain.Entities;
using eAppointment.Server.Domain.Repositories;
using GenericRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace eAppointment.Server.Application.Features.Patients.CreatePatient
{
    internal sealed class CreatePatientCommandHandler(
    IPatientRepository patientRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreatePatientCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            if (patientRepository.Any(p => p.IdentityNumber == request.IdentityNumber))
            {
                return Result<string>.Failure("This identity number already use");
            }

            Patient patient = mapper.Map<Patient>(request);

            await patientRepository.AddAsync(patient, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Patient create is successful";
        }
    }
}
