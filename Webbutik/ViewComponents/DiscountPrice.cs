using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webbutik.Models;
using Webbutik.ViewModels;

namespace Webbutik.ViewComponents
{
    public class DiscountPrice : ViewComponent
    {
        private readonly AppDbContext _context;

        public DiscountPrice(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (movie.DiscountStart != null && movie.DiscountEnd != null)
            {
                if (movie.DiscountStart < DateTime.Now && movie.DiscountEnd > DateTime.Now)
                {
                    movie.IsOnSale = true;
                }
                else if(movie.DiscountEnd < DateTime.Now)
                {
                    movie.IsOnSale = false;
                    movie.DiscountStart = null;
                    movie.DiscountEnd = null;
                    movie.Discount = null;
                    movie.DiscountPrice = null;
                }

                _context.Update(movie);
                _context.SaveChanges();
            }            

            return View(movie);
        }
    }
}
