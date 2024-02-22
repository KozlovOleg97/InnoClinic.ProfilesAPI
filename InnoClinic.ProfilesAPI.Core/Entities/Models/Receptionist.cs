using InnoClinic.ProfilesAPI.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.ProfilesAPI.Core.Entities.Models
{
    public class Receptionist : BaseEntityProfile
    {
        public Guid OfficeId { get; set; }
    }
}
