using AutoMapper;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Patient.Commands
{
    public sealed record RemoveExistingPatientCommand (int Id) : IRequest
    {
        public sealed class RemoveExistingPatientHandler : IRequestHandler<RemoveExistingPatientCommand, Unit>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IMapper _mapper;

            public RemoveExistingPatientHandler(IPatientRepository patientRepository, IMapper mapper)
            {
                _patientRepository = patientRepository;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(RemoveExistingPatientCommand request, CancellationToken cancellationToken)
            {
                await _patientRepository.DeleteAsync(request.Id);
                await _patientRepository.SaveAsync();

                return Unit.Value;
            }
        }
    }
}
