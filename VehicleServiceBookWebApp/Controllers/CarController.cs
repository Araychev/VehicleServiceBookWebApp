using Microsoft.AspNetCore.Mvc;

namespace VehicleServiceBookWebApp.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
