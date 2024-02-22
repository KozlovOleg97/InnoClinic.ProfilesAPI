﻿using AutoMapper;
using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Patient.Commands
{
    public sealed record CreateNewPatientCommand(PatientCreateDTO patientToCreate) : IRequest<PatientReadDTO>
    {
        //public class CreateNewPatientHandler : IRequestHandler<CreateNewPatientCommand, PatientReadDTO>
        //{
        //    private readonly IPatientRepository _patientRepository;
        //    private readonly IMapper _mapper;

        //    public CreateNewPatientHandler(IPatientRepository patientRepository, IMapper mapper)
        //    {
        //        _patientRepository = patientRepository;
        //        _mapper = mapper;
        //    }

        //    public async Task<PatientReadDTO?> Handle(
        //        CreateNewPatientCommand request, CancellationToken cancellationToken)
        //    {
        //        var patientToInsert = _mapper.Map<Patient>(request.patientToCreate); // mistake cs0118 
        //        await _patientRepository.AddAsync(patientToInsert);
        //        await _patientRepository.SaveAsync();
        //        var result = _mapper.Map<PatientReadDTO>(patientToInsert);

        //        return result == null ? null : await Task.FromResult(result);
        //    }
        //}
    }
}
