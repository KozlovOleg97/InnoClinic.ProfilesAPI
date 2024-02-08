using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using InnoClinic.ProfilesAPI.Core.Entities.Models;
using InnoClinic.ProfilesAPI.UseCases.DTOs;
using InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Commands;
using InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Queries.GetAllDoctors;

namespace InnoClinic.ProfilesAPI.UseCases.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DoctorDTO, Doctor>().ReverseMap();
            CreateMap<CreateDoctorResponse, CreateDoctorDTO>().ReverseMap();
            CreateMap<GetAllDoctorsResponse, GetAllDoctorsDTO>().ReverseMap();

            CreateMap<Patient, PatientDTO>().IncludeMembers(u => u.AdditionalInfo).ReverseMap();
            CreateMap<AdditionalInfo, PatientDTO>(MemberList.None).ReverseMap();
            

            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(t => t.GetInterfaces().Any(
                    i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] {this});
            }
        }
    }
}
