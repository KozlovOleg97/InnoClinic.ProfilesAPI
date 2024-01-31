using Microsoft.AspNetCore.Mvc;

namespace InnoClinic.ProfilesAPI.WebAPI.Controllers.v1
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
