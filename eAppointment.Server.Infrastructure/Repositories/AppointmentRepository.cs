using eAppointment.Server.Domain.Entities;
using eAppointment.Server.Domain.Repositories;
using eAppointment.Server.Infrastructure.Context;
using GenericRepository;

namespace eAppointment.Server.Infrastructure.Repositories
{
    internal sealed class AppointmentRepository : Repository<Appointment, ApplicationDbContext>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
