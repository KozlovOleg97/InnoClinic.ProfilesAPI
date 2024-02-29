using System.ComponentModel.DataAnnotations;

namespace InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO
{
    public class PatientReadDTO : BaseDto
    {
        [Required] string? FirstName { get; set; }
        [Required] string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public bool IsLinkedToAccount { get; set; }
        [Required] string? PhoneNumber { get; set; }
        [Required] DateTime DateOfBirth { get; set; }
    }
}
