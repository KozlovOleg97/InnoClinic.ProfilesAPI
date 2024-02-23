using AutoMapper;
using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Patient.Queries
{
    public record GetOnePatientByIdentifierQuery (int Id) : IRequest<PatientReadDTO>
    {
        public sealed class GetOnePatientByIdentifierHandler : IRequestHandler<GetOnePatientByIdentifierQuery, PatientReadDTO>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IMapper _mapper;

            public GetOnePatientByIdentifierHandler(IPatientRepository patientRepository, IMapper mapper)
            {
                _patientRepository = patientRepository;
                _mapper = mapper;
            }

            public async Task<PatientReadDTO> Handle(GetOnePatientByIdentifierQuery request, CancellationToken cancellationToken)
            {
                var patient = await _patientRepository.GetAsync(request.Id);
                return _mapper.Map<PatientReadDTO>(patient);
            }
        } 
    }
}
