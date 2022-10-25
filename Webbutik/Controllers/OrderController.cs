using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Net;
using Webbutik.Models;

namespace Webbutik.Controllers
{
    public class OrderController : Controller
    {

        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Distance(int id)
        {
            var order = _context.Orders.FirstOrDefault(i => i.Id == id);
            string url = "https://se.avstand.org/route.json?stops=" + "Galtabäck" + '|' + order.City;
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            HttpWebResponse response = null;
            response = (HttpWebResponse)request.GetResponse();

            string result = null;
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                result = sr.ReadToEnd();
                sr.Close();
            }

            var trimlist = JObject.Parse(result)["distance"];

            var stringing = trimlist.ToString();
            return View("Index",stringing);
        }

        public IActionResult ItemsInOrder(int id)
        {
            var orderDetails = _context.OrderDetails.Where(i => i.OrderId == id).Include(m => m.Movie);
            return View(orderDetails);

        }
    }
}
