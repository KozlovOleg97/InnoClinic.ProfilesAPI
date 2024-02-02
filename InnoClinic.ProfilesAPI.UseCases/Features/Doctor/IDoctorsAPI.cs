using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Commands;
using InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Queries.GetAllDoctors;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Doctor
{
    public interface IDoctorsAPI
    {
        Task<IEnumerable<GetAllDoctorsResponse>> GetAllDoctors();
        Task<CreateDoctorResponse> CreateDoctor(CreateDoctorRequest request);
    }
}
