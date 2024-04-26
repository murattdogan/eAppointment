using eAppointment.Server.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using eAppointment.Server.Domain.Enums;

namespace eAppointment.Server.Infrastructure.Configurations
{
    internal sealed class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(p => p.FirstName).HasColumnType("varchar(50)");
            builder.Property(p => p.LastName).HasColumnType("varchar(50)");
            //builder.HasIndex(x => new { x.FirstName, x.LastName }).IsUnique();

            builder.Property(p => p.Department)
                .HasConversion(v => v.Value, v => DepartmentEnum.FromValue(v))
                .HasColumnName("Department");
        }
    }
}
