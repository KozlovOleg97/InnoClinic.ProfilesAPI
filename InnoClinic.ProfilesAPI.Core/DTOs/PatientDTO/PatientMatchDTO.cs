namespace InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO
{
    public class PatientMatchDTO
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
