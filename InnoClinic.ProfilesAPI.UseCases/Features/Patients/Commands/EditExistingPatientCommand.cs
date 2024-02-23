using AutoMapper;
using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Patient.Commands
{
    public sealed record EditExistingPatientCommand (PatientUpdateDTO patientToUpdate) : IRequest
    {
        public sealed class EditExistingPatientHandler : IRequestHandler<EditExistingPatientCommand, Unit>
        {
            private readonly IPatientRepository _patientRepository;
            private readonly IMapper mapper;

            public EditExistingPatientHandler(IPatientRepository patientRepository, IMapper mapper)
            {
                _patientRepository = patientRepository;
                this.mapper = mapper;
            }

            public async Task
        }
    }
}
