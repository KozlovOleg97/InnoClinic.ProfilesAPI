using InnoClinic.ProfilesAPI.UseCases.DTOs;
using InnoClinic.ProfilesAPI.UseCases.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.ProfilesAPI.UseCases.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        

        public Task<PatientDTO> AddPatientAsync(PatientDTO patientDTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PatientDTO> GetPatientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PatientDTO>> GetPatientListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateStudentAsync(PatientDTO studentDetails)
        {
            throw new NotImplementedException();
        }
    }
}
