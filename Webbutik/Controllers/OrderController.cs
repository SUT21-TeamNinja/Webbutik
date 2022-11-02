using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Net;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Webbutik.Models;

namespace Webbutik.Controllers
{
    public class OrderController : Controller
    { 
        private readonly AppDbContext _context;
        private readonly Cart _cart;
        public OrderController(AppDbContext context, Cart cart)

        {
            _context = context;
            _cart = cart;
        }

        public async Task<IActionResult> CheckOutAsync()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CheckOutAsync(Order order)
        {
            _cart.CartItems = await _cart.GetCartItemsAsync();

            if (_cart.CartItems.Count == 0)
            {
                return View("Empty");
            }
            if (ModelState.IsValid)
            {
                order.OrderDate = DateTime.Now;
                order.OrderTotal = await _cart.GetOrderTotalAsync();
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();

                foreach (var item in await _cart.GetCartItemsAsync())
                {
                    await _context.OrderDetails.AddAsync(new OrderDetail
                    {
                        OrderId = order.Id,
                        MovieId = item.MovieId,
                        Quantity = item.Amount,
                        Price = item.Movie.Price                        

                    });
                }
                

                _context.CartItems.RemoveRange(_context.CartItems.Where(c => c.CartId == _cart.CartSessionKey));
                await _context.SaveChangesAsync();
            }
            return View();
        }


        public async Task<IActionResult> Distance(int id)
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
            var orderDetails = _context.OrderDetails.Where(i => i.OrderId == id).Include(m => m.Movie).Include(o => o.Order);
            return View(orderDetails);

        }

        public IActionResult ChangeCurrency(int id) 
        {
            var order = _context.Orders.FirstOrDefault(i => i.Id==id);
            if (order == null)
            {
                return NotFound();
            }
            decimal? amount = order.OrderTotal;
           
            string Currency = "USD";
            string url = "https://api.apilayer.com/exchangerates_data/convert?to=" + Currency + "&from=SEK&amount=" + amount;


            WebRequest request = WebRequest.Create(url);
            request.Headers.Add("apikey", "yCqdysS5U7aG92l5q90ClG2vN9kL7Tnm");
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

            var trimlist = JObject.Parse(result)["result"];

            var stringing = trimlist.ToString();

            decimal ToADecimal = Convert.ToDecimal(stringing);

            decimal rounded = Math.Round(ToADecimal, 0);

            int ConvertedResult = Convert.ToInt32(rounded);

            order.OrderTotal = ConvertedResult;

            var orderDetails = _context.OrderDetails.Where(i => i.OrderId == id).Include(m => m.Movie).Include(o => o.Order);
            return View("ItemsInOrder", orderDetails);

            

            

        }
    }
}
