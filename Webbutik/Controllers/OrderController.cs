using Microsoft.AspNetCore.Mvc;

namespace Webbutik.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
