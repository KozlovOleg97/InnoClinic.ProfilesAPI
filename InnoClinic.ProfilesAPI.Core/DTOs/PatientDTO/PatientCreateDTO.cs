using System.ComponentModel.DataAnnotations;

namespace InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO
{
    public class PatientCreateDTO
    {
        [Required] public required string FirstName { get; set; }
        [Required] public required string LastName { get; set; }
        public required string MiddleName { get; set; }
        public bool IsLinkedToAccount { get; set; } = false;
        [Required] public required string PhoneNumber { get; set; }
        [Required] DateTime DateOfBirth { get; set; }
    }
}
