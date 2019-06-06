using Microsoft.AspNetCore.Mvc;

namespace DroneDelivery_after.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}