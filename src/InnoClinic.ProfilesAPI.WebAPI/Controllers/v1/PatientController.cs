using AutoMapper;
using InnoClinic.ProfilesAPI.UseCases.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace InnoClinic.ProfilesAPI.WebAPI.Controllers.v1
{
    public class PatientController : Controller
    {
        private readonly IMapper _mapper;

        public PatientController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            

            
            return View();
        }
    }
}
