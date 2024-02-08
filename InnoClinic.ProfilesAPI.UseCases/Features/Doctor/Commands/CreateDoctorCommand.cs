﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Commands
{
    public class CreateDoctorCommand : IRequest<CreateDoctorDTO>
    {
        public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand, CreateDoctorDTO>
        {
            private readonly IDoctorsAPI _doctorsApi;
            private readonly IMapper _mapper;

            public CreateDoctorCommandHandler(IDoctorsAPI doctorsApi, IMapper mapper)
            {
                _doctorsApi = doctorsApi;
                _mapper = mapper;
            }

            public async Task<CreateDoctorDTO> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
            {
                var response = await _doctorsApi.CreateDoctor(_mapper.Map<CreateDoctorRequest>(request));
                return _mapper.Map<CreateDoctorDTO>(response);
            }
        }
    }

    
}
