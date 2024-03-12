using AutoMapper;
using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Patients.Commands
{
    public sealed record CreatePatientCommand(PatientCreateDTO patientToCreate) : IRequest<PatientReadDTO>
    {
        public class CreateNewPatientHandler : IRequestHandler<CreatePatientCommand, PatientReadDTO>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IMapper _mapper;

            public CreateNewPatientHandler(IPatientRepository patientRepository, IMapper mapper)
            {
                _patientRepository = patientRepository;
                _mapper = mapper;
            }

            public async Task<PatientReadDTO> Handle(
                CreatePatientCommand request, CancellationToken cancellationToken)
            {


                var patientToInsert = _mapper.Map<Core.Entities.Models.Patient>(request.patientToCreate);
                await _patientRepository.AddAsync(patientToInsert);
                var result = _mapper.Map<PatientReadDTO>(patientToInsert);

                return result;
            }
        }
    }
}
