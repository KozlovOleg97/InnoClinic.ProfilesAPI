using AutoMapper;
using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Patients.Commands
{
    public sealed record EditExistingPatientCommand (PatientUpdateDTO patientToUpdate) : IRequest
    {
        public sealed class EditExistingPatientHandler : IRequestHandler<EditExistingPatientCommand, Unit>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IMapper _mapper;

            public EditExistingPatientHandler(IPatientRepository patientRepository, IMapper mapper)
            {
                _patientRepository = patientRepository;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(EditExistingPatientCommand request, CancellationToken cancellationToken)
            {
                var patientToUpdate = _mapper.Map<InnoClinic.ProfilesAPI.Core.Entities.Models.Patient>(request.patientToUpdate);
                await _patientRepository.UpdateAsync(patientToUpdate);
                return Unit.Value;
            }
        }
    }
}
