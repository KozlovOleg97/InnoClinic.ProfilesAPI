using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.ProfilesAPI.Core.Entities.Common
{
    public class BaseEntityProfile
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Guid PhotoId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }

        //public string GetFullName()
        //{
        //    return $"{FirstName} {LastName} {MiddleName}";
        //}
    }
}
