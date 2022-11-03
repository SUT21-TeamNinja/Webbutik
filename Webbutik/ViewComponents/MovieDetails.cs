using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webbutik.Models;

namespace Webbutik.ViewComponents
{
    public class MovieDetails : ViewComponent
    {
        private readonly AppDbContext _context;

        public MovieDetails(AppDbContext context) => _context = context;

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
            return View(movie);
        }
    }
}
