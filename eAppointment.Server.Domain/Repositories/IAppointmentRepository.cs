using eAppointment.Server.Domain.Entities;
using GenericRepository;

namespace eAppointment.Server.Domain.Repositories
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
    }
}
