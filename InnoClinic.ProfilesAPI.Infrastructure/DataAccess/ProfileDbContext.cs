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
       

        public ProfileDbContext(DbContextOptions<ProfileDbContext> options) : base(options) { }

        //public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Patient> Patients { get; set; }
        //public DbSet<Receptionist> Receptionists => Set<Receptionist>();

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Patient>().Property(e => e.Id).HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.Entity<Patient>().Property(e => e.FirstName).IsRequired();
            modelBuilder.Entity<Patient>().Property(e => e.LastName).IsRequired();
            modelBuilder.Entity<Patient>().Property(e => e.DateOfBirth).IsRequired();

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProfileDbContext).Assembly);
            //modelBuilder.Entity<Doctor>().ToTable("Doctor");
            //modelBuilder.Entity<Patient>().ToTable("Patient");
            //modelBuilder.Entity<Receptionist>().ToTable("Receptionist");
        }
    }
}
