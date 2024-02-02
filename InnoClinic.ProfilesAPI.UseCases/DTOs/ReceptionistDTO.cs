using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.ProfilesAPI.UseCases.DTOs
{
    public class ReceptionistDTO
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Guid OfficeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

    }
}
