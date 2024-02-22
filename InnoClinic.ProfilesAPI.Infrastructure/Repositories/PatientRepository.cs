using InnoClinic.ProfilesAPI.Core.Entities.Models;
using InnoClinic.ProfilesAPI.Infrastructure.DataAccess;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;

namespace InnoClinic.ProfilesAPI.Infrastructure.Repositories
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        private readonly ProfileDbContext _profileDbContext;
        public PatientRepository(ProfileDbContext profileDbContext) : base(profileDbContext) 
            => _profileDbContext = profileDbContext;
    }
}
