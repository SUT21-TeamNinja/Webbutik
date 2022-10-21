using Microsoft.AspNetCore.Mvc;
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
            _cart.CartItems = await _cart.GetCartItemsAsync();

            if (_cart.CartItems.Count == 0)
            {
                return View("Empty");
            }
            return View();
        }

        public async Task<IActionResult> CheckOutAsync(Order order)
        {
            return View();
        }
    }
}
