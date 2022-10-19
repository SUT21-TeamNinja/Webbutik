using Microsoft.AspNetCore.Mvc;

namespace Webbutik.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
