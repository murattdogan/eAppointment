using eAppointment.Server.Domain.Entities;
using eAppointment.Server.Domain.Repositories;
using eAppointment.Server.Infrastructure.Context;
using GenericRepository;

namespace eAppointment.Server.Infrastructure.Repositories
{
    internal sealed class PatientRepository : Repository<Patient, ApplicationDbContext>, IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
