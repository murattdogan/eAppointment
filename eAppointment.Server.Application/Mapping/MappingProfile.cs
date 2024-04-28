using AutoMapper;
using eAppointment.Server.Application.Features.Doctors.CreateDoctor;
using eAppointment.Server.Application.Features.Doctors.UpdateDoctor;
using eAppointment.Server.Application.Features.Patients.CreatePatient;
using eAppointment.Server.Application.Features.Patients.UpdatePatient;
using eAppointment.Server.Application.Features.Users.CreateUser;
using eAppointment.Server.Application.Features.Users.UpdateUser;
using eAppointment.Server.Domain.Entities;
using eAppointment.Server.Domain.Enums;

namespace eAppointment.Server.Application.Mapping
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateDoctorCommand, Doctor>().ForMember(member => member.Department, options =>
            {
                options.MapFrom(map => DepartmentEnum.FromValue(map.DepartmentValue));
            });

            CreateMap<UpdateDoctorCommand, Doctor>().ForMember(member => member.Department, options =>
            {
                options.MapFrom(map => DepartmentEnum.FromValue(map.DepartmentValue));
            });

            CreateMap<CreatePatientCommand, Patient>();
            CreateMap<UpdatePatientCommand, Patient>();

            CreateMap<CreateUserCommand, AppUser>();
            CreateMap<UpdateUserCommand, AppUser>();
        }
    }
}