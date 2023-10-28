using Microsoft.AspNetCore.Mvc;

namespace TurboazTask1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
