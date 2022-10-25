using Microsoft.AspNetCore.Mvc;
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
