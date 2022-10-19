using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Webbutik.Models
{
    public class Cart
    {
        private readonly AppDbContext _context;
        public Cart(AppDbContext context) => _context = context;

        public string CartSessionKey { get; set; }
        public ICollection<CartItem> CartItems { get; set; }


        public static Cart GetCart(IServiceProvider service)
        {
            var session = service.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            var context = service.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new Cart(context) { CartSessionKey = cartId };
        }

        public async void AddToCart(Movie movie, int count)
        {
            var cartItem = await _context.CartItems.SingleOrDefaultAsync(
                c => c.CartId == CartSessionKey
                && c.MovieId == movie.Id);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    CartId = CartSessionKey,
                    MovieId = movie.Id,
                    Amount = count,
                    CreatedAt = DateTime.Now,
                    Movie = movie
                };
                await _context.CartItems.AddAsync(cartItem);
            }
            else
                cartItem.Amount++;

            await _context.SaveChangesAsync();
        }
        public async Task<ICollection<CartItem>> GetCartItemsAsync()
        {
            return CartItems ??= await _context.CartItems
            .Where(c => c.CartId == CartSessionKey)
            .Include(m => m.Movie).ToListAsync();
        }
    }
}
