using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using InnoClinic.ProfilesAPI.Core.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InnoClinic.ProfilesAPI.Infrastructure.DataAccess
{
    public class ProfileDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ProfileDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Receptionist> Receptionists => Set<Receptionist>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProfileDbContext).Assembly);
            modelBuilder.Entity<Doctor>().ToTable("Doctor");
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<Receptionist>().ToTable("Receptionist");
        }
    }
}
