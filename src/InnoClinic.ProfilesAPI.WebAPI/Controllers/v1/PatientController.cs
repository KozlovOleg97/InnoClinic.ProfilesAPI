using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.UseCases.Features.Patient.Commands;
using InnoClinic.ProfilesAPI.UseCases.Features.Patient.Queries;
using InnoClinic.ProfilesAPI.UseCases.Features.Patients.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InnoClinic.ProfilesAPI.WebAPI.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {
        private readonly IMediator _mediator;

        public PatientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var result = await _mediator.Send(new GetAllPatientsQuery());
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _mediator.Send(new GetOnePatientByIdentifierQuery(id));
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostPatient([FromBody] PatientCreateDTO patientCreateDTO)
        {
            var result = await _mediator.Send(new CreateNewPatientCommand(patientCreateDTO));

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient(Guid id, [FromBody] PatientUpdateDTO patientUpdateDTO, Guid guid)
        {
            if (guid != patientUpdateDTO.Id) return BadRequest();

            await _mediator.Send(new EditExistingPatientCommand(patientUpdateDTO));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(Guid id)
        {
            await _mediator.Send(new RemoveExistingPatientCommand(id));
            return NoContent();
        }
    }
}
