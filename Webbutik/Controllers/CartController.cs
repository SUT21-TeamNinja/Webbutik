using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webbutik.Models;
using Webbutik.ViewModels;

namespace Webbutik.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;
        private readonly Cart _cart;
        public CartController(AppDbContext context, Cart cart)
        {
            _context = context;
            _cart = cart;
        }

        public async Task<IActionResult> Index()
        {
            _cart.CartItems = await _cart.GetCartItemsAsync();

            var vm = new CartViewModel
            {
                Cart = _cart
            };
            return View(vm);
        }
        public async Task<IActionResult> AddToCart(int id)
        {
            var movieToAdd = await _context.Movies.FirstOrDefaultAsync(m=>m.Id == id);
             
            if (movieToAdd != null)
            {
                _cart.AddToCart(movieToAdd, 1);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
