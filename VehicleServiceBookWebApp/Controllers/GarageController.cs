using Microsoft.AspNetCore.Mvc;

namespace VehicleServiceBookWebApp.Controllers
{
    public class GarageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
