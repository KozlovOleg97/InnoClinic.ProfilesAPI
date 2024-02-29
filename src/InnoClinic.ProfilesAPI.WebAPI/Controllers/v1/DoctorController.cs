using Microsoft.AspNetCore.Mvc;

namespace InnoClinic.ProfilesAPI.WebAPI.Controllers.v1
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }

    }
}
