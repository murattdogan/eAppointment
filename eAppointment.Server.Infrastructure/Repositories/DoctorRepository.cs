using eAppointment.Server.Domain.Entities;
using eAppointment.Server.Domain.Repositories;
using eAppointment.Server.Infrastructure.Context;
using GenericRepository;

namespace eAppointment.Server.Infrastructure.Repositories
{
    internal sealed class DoctorRepository : Repository<Doctor, ApplicationDbContext>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
