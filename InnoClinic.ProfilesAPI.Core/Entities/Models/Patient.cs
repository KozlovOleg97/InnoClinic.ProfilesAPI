using InnoClinic.ProfilesAPI.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.ProfilesAPI.Core.Entities.Models
{
    public partial class Patient : BaseEntityProfile
    {
        public string? PhoneNumber { get; set; }
        public bool IsLinkedToAccount { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
