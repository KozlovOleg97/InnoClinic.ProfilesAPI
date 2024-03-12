using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Patients.Queries
{
    public record GetPatientMatchQuery(Guid PatientId) : IRequest<PatientMatchDTO>;

    public class CheckPatientMatchHandler : IRequestHandler<GetPatientMatchQuery, PatientMatchDTO>
    {
        private readonly IPatientRepository _patientRepository;

        public CheckPatientMatchHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<PatientMatchDTO> Handle(GetPatientMatchQuery request, CancellationToken cancellationToken)
        {
            var patient = await _patientRepository.
        }
    }
}
