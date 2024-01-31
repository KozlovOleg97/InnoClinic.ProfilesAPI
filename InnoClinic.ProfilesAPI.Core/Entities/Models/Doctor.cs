using InnoClinic.ProfilesAPI.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.ProfilesAPI.Core.Entities.Models
{
    public class Doctor : OverallBaseEntityProfile
    {
        public Guid SpecializationId { get; set; }
        public Guid OfficeId { get; set; }
        public DateTime CareerStartYear { get; set; }
        // public string SpecializationName { get; set; }
    }
}
