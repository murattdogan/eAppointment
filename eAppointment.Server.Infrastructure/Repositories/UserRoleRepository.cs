using eAppointment.Server.Domain.Entities;
using eAppointment.Server.Domain.Repositories;
using eAppointment.Server.Infrastructure.Context;
using GenericRepository;

namespace eAppointment.Server.Infrastructure.Repositories
{
    internal sealed class UserRoleRepository : Repository<AppUserRole, ApplicationDbContext>, IUserRoleRepository
    {
        public UserRoleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
