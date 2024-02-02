using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InnoClinic.ProfilesAPI.Core.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace InnoClinic.ProfilesAPI.Infrastructure.DataAccess
{
    public interface IApplicationDbContext
    {
        public DbSet<Doctor> Doctors { get; }
        public DbSet<Patient> Patients { get; }
        public DbSet<Receptionist> Receptionists { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
