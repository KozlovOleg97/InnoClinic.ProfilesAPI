using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Commands
{
    public class CreateDoctorDTO
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Guid SpecializationId { get; set; }
        public Guid OfficeId { get; set; }

        public static void Mapping(Profile profile)
        {
            profile.CreateMap<CreateDoctorResponse, CreateDoctorDTO>();
        }
    }
}
