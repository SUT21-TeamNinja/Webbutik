using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
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

        public static Cart GetCart(IServiceProvider service)
        {
            var session = service.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            var context = service.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new Cart(context) { CartSessionKey = cartId };
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
        public async Task<IActionResult> AddToCart(int id, string currentPage)
        {
            var movieToAdd = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (movieToAdd != null)
            {

                var cartItem = await _context.CartItems.SingleOrDefaultAsync(
                c => c.CartId == _cart.CartSessionKey
                && c.MovieId == movieToAdd.Id);

                if (cartItem == null)
                {
                    cartItem = new CartItem
                    {
                        CartId = _cart.CartSessionKey,
                        MovieId = movieToAdd.Id,
                        Amount = 1,
                        CreatedAt = DateTime.Now,
                        Movie = movieToAdd
                    };
                    await _context.CartItems.AddAsync(cartItem);
                }
                else
                    cartItem.Amount++;

                await _context.SaveChangesAsync();
            }
            return RedirectToAction("index", currentPage);

        }

        public async Task<IActionResult> RemoveFromCart(int id)
        {
            var movieToRemove = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movieToRemove != null)
            {
                var cartItem = await _context.CartItems.SingleOrDefaultAsync(
                c => c.CartId == _cart.CartSessionKey
                && c.MovieId == movieToRemove.Id);

                if (cartItem != null)
                {
                    if (cartItem.Amount > 1)
                        cartItem.Amount--;
                    else
                        _context.CartItems.Remove(cartItem);
                }
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> ClearCart()
        {
            var cartItems = _context.CartItems.Where(c => c.CartId == _cart.CartSessionKey);

            _context.CartItems.RemoveRange(cartItems);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }



    }
}
