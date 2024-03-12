using InnoClinic.ProfilesAPI.Core.Entities.Common;

namespace InnoClinic.ProfilesAPI.Core.Entities.Models
{
    public class Patient : BaseEntityProfile
    {
        public string? PhoneNumber { get; set; }
        public bool IsLinkedToAccount { get; set; } = false;
        public DateTime DateOfBirth { get; set; }
    }
}
