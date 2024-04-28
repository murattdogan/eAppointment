﻿using eAppointment.Server.Domain.Entities;
using eAppointment.Server.Domain.Repositories;
using GenericRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace eAppointment.Server.Application.Features.Patients.DeletePatientById
{
    internal sealed class DeletePatientByIdCommandHandler(
    IPatientRepository patientRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeletePatientByIdCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(DeletePatientByIdCommand request, CancellationToken cancellationToken)
        {
            Patient? patient = await patientRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

            if (patient is null)
            {
                return Result<string>.Failure("Patient not found");
            }

            patientRepository.Delete(patient);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Patient delete is successful";
        }
    }
}
