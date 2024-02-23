using InnoClinic.ProfilesAPI.Core.Entities.Common;

namespace InnoClinic.ProfilesAPI.Core.Entities.Models
{
    public class Receptionist : BaseEntityProfile
    {
        public Guid OfficeId { get; set; }
    }
}
