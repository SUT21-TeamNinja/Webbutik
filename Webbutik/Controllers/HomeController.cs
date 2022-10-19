using Microsoft.AspNetCore.Mvc;

namespace Webbutik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
