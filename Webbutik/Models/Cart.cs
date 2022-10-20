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


        

        public async Task<ICollection<CartItem>> GetCartItemsAsync()
        {
            return CartItems ??= await _context.CartItems
            .Where(c => c.CartId == CartSessionKey)
            .Include(m => m.Movie).ToListAsync();
        }
    }
}
