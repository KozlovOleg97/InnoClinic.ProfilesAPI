using AutoMapper;
using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Patient.Queries
{
    public record GetAllPatientsQuery : IRequest<List<PatientReadDTO>>
    {
        public class GetAllPatientsHandler : IRequestHandler<GetAllPatientsQuery, List<PatientReadDTO>>
        {
            private readonly IPatientRepository _patientRepository;
            private IMapper _mapper;

            public GetAllPatientsHandler(IPatientRepository patientRepository, IMapper mapper)
            {
                _patientRepository = patientRepository;
                _mapper = mapper;
            }

            public async Task<List<PatientReadDTO>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
            {
                var patientList = await _patientRepository.GetAllAsync();
                return _mapper.Map<List<PatientReadDTO>>(patientList);
            }
        }
    }
}
