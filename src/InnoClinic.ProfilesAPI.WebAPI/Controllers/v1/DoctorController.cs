using AutoMapper;
using InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Commands;
using InnoClinic.ProfilesAPI.UseCases.Features.Doctor.Queries.GetAllDoctors;
using Microsoft.AspNetCore.Mvc;

namespace InnoClinic.ProfilesAPI.WebAPI.Controllers.v1
{
    public class DoctorController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllDoctorsDTO>>> GetAllDoctors()
        {
            var response = await Mediator.Send(new GetAllDoctorsQuery());

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateDoctorDTO>> CreateDoctor(CreateDoctorCommand command)
        {
            var response = await Mediator.Send(command);

            return CreatedAtAction(nameof(CreateDoctor), response);
        }

    }
}
