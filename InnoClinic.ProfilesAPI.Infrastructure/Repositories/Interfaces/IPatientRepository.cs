using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Core.Entities.Models;

namespace InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Task<Patient> GetByIdAsync(Guid id);
        Task<int> CalculateMatchScoreAsync(PatientMatchDTO patientMatchDTO);
    }
}
