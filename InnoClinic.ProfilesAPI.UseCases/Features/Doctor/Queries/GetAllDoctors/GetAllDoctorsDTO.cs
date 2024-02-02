using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AutoMapper;
using InnoClinic.ProfilesAPI.UseCases.Mappings;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Queries.GetAllDoctors
{
    public class GetAllDoctorsDTO : IMapFrom<GetAllDoctorsResponse>
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid SpecializationId { get; set; }

        public Guid OfficeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string SpecializationName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime CareerStartYear { get; set; }

        public string Status { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetAllDoctorsResponse, GetAllDoctorsDTO>();
        }
    }
}
