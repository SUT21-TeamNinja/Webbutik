using Microsoft.AspNetCore.Mvc;

namespace Webbutik.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test(string from, string too)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://se.avstand.org/route.json?stops=" +from + '|' +too)
            };
            return View(request);
        }
    }
}
