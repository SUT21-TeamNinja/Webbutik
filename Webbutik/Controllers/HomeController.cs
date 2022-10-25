using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webbutik.Models;

namespace Webbutik.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private static bool IsUpdated = false;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Start()
        {
            var list = await FakeMovies.GetMoviesFromApi();
            if (!IsUpdated)
            {
                await Populate(list);
                IsUpdated = true;
            }
            return View();
        }

        public async Task Populate(List<Movie> list)
        {
            for (int i = 1; i < _context.Movies.Count(); i++)
            {
                var movie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == i);
                movie.Title = list[i].Title;
                movie.Description = list[i].Description;
                movie.ImageUrl = list[i].ImageUrl;
                movie.ReleaseDate = list[i].ReleaseDate;
                movie.Stars = list[i].Stars;
                movie.Writers = list[i].Writers;
                movie.Directors = list[i].Directors;
                Console.WriteLine("updated");
            }
            await _context.SaveChangesAsync();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
