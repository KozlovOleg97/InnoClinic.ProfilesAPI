using InnoClinic.ProfilesAPI.UseCases.DTOs;

namespace InnoClinic.ProfilesAPI.UseCases.Repositories.Interfaces
{
    public interface IPatientRepository
    {
        public Task<List<PatientDTO>> GetPatientListAsync();
        public Task<PatientDTO> GetPatientByIdAsync(int id);
        public Task<PatientDTO> AddPatientAsync(PatientDTO patientDTO);
        public Task<int> UpdateStudentAsync(PatientDTO studentDetails);
        public Task<int> DeleteStudentAsync(int id);
    }
}
