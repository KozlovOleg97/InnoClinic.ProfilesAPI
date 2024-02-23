using AutoMapper;
using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Core.Entities.Models;

namespace InnoClinic.ProfilesAPI.UseCases.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Patient, PatientReadDTO>().ReverseMap();
            CreateMap<PatientCreateDTO, Patient>().ReverseMap();
            CreateMap<PatientUpdateDTO, Patient>().ReverseMap();
        }
    }
}
