using AutoMapper;
using InnoClinic.ProfilesAPI.Core.DTOs.PatientDTO;
using InnoClinic.ProfilesAPI.Core.Entities.Models;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
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
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mediator.Send(new GetOnePatientByIdentifierQuery(id));
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostPatient([FromBody] PatientCreateDTO patientCreateDTO)
        {
            var result = await _mediator.Send(new CreateNewPatientCommand(patientCreateDTO));

            return CreatedAtAction("Get", new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient(int id, [FromBody] PatientUpdateDTO patientUpdateDTO)
        {
            if (id != patientUpdateDTO.Id) return BadRequest();

            await _mediator.Send(new EditExistingPatientCommand(patientUpdateDTO));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            await _mediator.Send(new RemoveExistingPatientCommand(id));
            return NoContent();
        }
    }
}
