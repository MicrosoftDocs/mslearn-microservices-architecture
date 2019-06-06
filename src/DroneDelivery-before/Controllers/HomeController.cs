using Microsoft.AspNetCore.Mvc;

namespace DroneDelivery_before.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}