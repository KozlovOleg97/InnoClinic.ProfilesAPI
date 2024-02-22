using AutoMapper;
using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Patient.Commands
{
    public sealed record EditExistingPatientCommand (PatientUpdateDTO patientToUpdate) : IRequest
    {
        
    }
}
