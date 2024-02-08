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
    }
}
