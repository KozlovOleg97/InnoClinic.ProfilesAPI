using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Core.Entities.Models;
using InnoClinic.ProfilesAPI.Core.Services;
using InnoClinic.ProfilesAPI.Infrastructure.DataAccess;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoClinic.ProfilesAPI.Infrastructure.Repositories
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        private readonly ProfileDbContext _profileDbContext;
        private readonly PatientScoringService _patientScoringService;
        public PatientRepository(ProfileDbContext profileDbContext, PatientScoringService patientScoringService) : base(profileDbContext)
        {
            _profileDbContext = profileDbContext;
            _patientScoringService = patientScoringService;
        }

        public async Task<Patient> GetByIdAsync(Guid id)
        {
            return await _profileDbContext.Patients.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<int> CalculateMatchScoreAsync(PatientMatchDTO patientMatchDTO)
        {
            return await _patientScoringService.CalculateMatchScore(patientMatchDTO);
        }
    }
}
