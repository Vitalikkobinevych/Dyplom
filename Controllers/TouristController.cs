using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TouristController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
