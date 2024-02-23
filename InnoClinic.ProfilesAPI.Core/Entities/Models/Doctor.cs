using InnoClinic.ProfilesAPI.Core.Entities.Common;
using InnoClinic.ProfilesAPI.Core.Entities.Enums;

namespace InnoClinic.ProfilesAPI.Core.Entities.Models
{
    public class Doctor : BaseEntityProfile
    {
        public DateTime DateOfBirth { get; set; }
        public Guid SpecializationId { get; set; }
        
        public Guid OfficeId { get; set; }
        public DateTime CareerStartYear { get; set; }
        public Status Status { get; set; }
    }
}
