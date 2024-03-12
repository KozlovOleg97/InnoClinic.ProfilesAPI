using AutoMapper;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Patient.Commands
{
    public sealed record RemovePatientCommand(Guid Id) : IRequest
    {
        public sealed class RemoveExistingPatientHandler : IRequestHandler<RemovePatientCommand, Unit>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IMapper _mapper;

            public RemoveExistingPatientHandler(IPatientRepository patientRepository, IMapper mapper)
            {
                _patientRepository = patientRepository;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(RemovePatientCommand request, CancellationToken cancellationToken)
            {
                await _patientRepository.DeleteAsync(request.Id);

                return Unit.Value;
            }
        }
    }
}
