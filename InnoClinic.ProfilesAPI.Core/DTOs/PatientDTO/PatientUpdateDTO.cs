namespace InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO
{
    public class PatientUpdateDTO : BaseDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public bool IsLinkedToAccount { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
