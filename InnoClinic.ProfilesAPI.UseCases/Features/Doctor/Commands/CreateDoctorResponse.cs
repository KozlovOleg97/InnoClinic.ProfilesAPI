using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Commands
{
    public class CreateDoctorResponse
    {
        [JsonPropertyName("Id")]
        public Guid Id { get; set; }

        [JsonPropertyName("AccountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("SpecializationId")]
        public Guid SpecializationId { get; set; }

        [JsonPropertyName("OfficeId")]
        public Guid OfficeId { get; set; }

        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonPropertyName("MiddleName")]
        public string MiddleName { get; set; }

        [JsonPropertyName("SpecializationName")]
        public string SpecializationName { get; set; }

        [JsonPropertyName("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [JsonPropertyName("CarrerStartYear")]
        public DateTime CareerStartYear { get; set; }

        [JsonPropertyName("Status")]
        public string Status { get; set; }
    }
}
