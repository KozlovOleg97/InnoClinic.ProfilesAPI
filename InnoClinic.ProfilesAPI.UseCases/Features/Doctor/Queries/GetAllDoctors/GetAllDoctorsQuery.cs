using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;

namespace InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Queries.GetAllDoctors
{
    public class GetAllDoctorsQuery : IRequest<IEnumerable<GetAllDoctorsDTO>>
    {
        public class GetAllDoctorsQueryHandler : IRequestHandler<GetAllDoctorsQuery, IEnumerable<GetAllDoctorsDTO>>
        {
            private readonly IDoctorsAPI _doctorsApi;
            private readonly IMapper _mapper;

            public GetAllDoctorsQueryHandler(IDoctorsAPI doctorsApi, IMapper mapper)
            {
                _doctorsApi = doctorsApi;
                _mapper = mapper;
            }

            public async Task<IEnumerable<GetAllDoctorsDTO>> Handle(
                GetAllDoctorsQuery request, CancellationToken cancellationToken)
            {
                var doctors = await _doctorsApi.GetAllDoctors();
                return _mapper.Map<IEnumerable<GetAllDoctorsDTO>>(doctors);
            }
        }
    }
}
