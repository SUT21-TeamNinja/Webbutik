using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webbutik.Models;
using Webbutik.ViewModels;

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

        public async Task<IActionResult> Index()
        {
            var list = await FakeMovies.GetMoviesFromApi();
            if (!IsUpdated)
            {
                //await Populate(list);
                IsUpdated = true;
            }
            var movies = await _context.Movies.ToListAsync();
            var viewModel = new MovieListViewModel
            {
                Movies = movies
            };
            return View(viewModel);
        }

        public async Task Populate(List<Movie> list)
        {
            for (int i = 1; i < _context.Movies.Count(); i++)
            {
                var movie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == i);
                movie.Title = list[i].Title;
                movie.ImageUrl = list[i].ImageUrl;
                movie.Directors = list[i].Directors;
                movie.ImDbRating = list[i].ImDbRating;
                movie.Genres = list[i].Genres;
                movie.ContentRating = list[i].ContentRating;
                movie.Description = list[i].Description;
                movie.Stars = list[i].Stars;
                movie.ImdbId = list[i].ImdbId;
                movie.RunTimeStr = list[i].RunTimeStr;
                movie.ReleaseDate = list[i].ReleaseDate;
                movie.Directors = list[i].Directors;
                Console.WriteLine("updated");
            }
            await _context.SaveChangesAsync();
        }


    }
}
