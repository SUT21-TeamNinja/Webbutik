using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using Webbutik.Models;
using Webbutik.ViewModels;
using X.PagedList;

namespace Webbutik.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        private static bool IsUpdated = false;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Movies


        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        public ViewResult AllMovies(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Sort_Movie_Down" : "";
            ViewBag.DateSortParm = sortOrder == "Sort_Movie_Up" ? "Sort_Date_Down" : "Sort_Date_Up";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var movieListVM = new MovieListViewModel() { Movies = _context.Movies };
            var movies = movieListVM.Movies;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(m => m.Title.ToLower().Contains(searchString.ToLower()));
            }

            switch (sortOrder)
            {
                case "Sort_Movie_Down":
                    movies = movies.OrderBy(m => m.Title);
                    break;
                case "Sort_Movie_Up":
                    movies = movies.OrderByDescending(m => m.Title);
                    break;
                case "Sort_Date_Down":
                    movies = movies.OrderBy(m => m.ReleaseDate);
                    break;
                case "Sort_Date_Up":
                    movies = movies.OrderByDescending(m => m.ReleaseDate);
                    break;
                default:  // Name ascending 
                    movies = movies.OrderBy(m => m.Title);
                    break;
            }

            int pageSize = 18;
            int pageNumber = (page ?? 1);
            return View(movies.ToPagedList(pageNumber, pageSize));
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,ImageUrl,ReleaseDate,Stars,Writers,Directors,IsOnSale,Discount")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManageProducts));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,ImageUrl,ReleaseDate,Stars,Writers,Directors,IsOnSale,Discount")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ManageProducts));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Movies == null)
            {
                return Problem("Entity set 'AppDbContext.Movies'  is null.");
            }
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }

        [Authorize(Roles = "Admin")]
        public ViewResult Admin()
        {
            return View();
        }

        public async Task<IActionResult> ManageProducts()
        {
            return View(await _context.Movies.ToListAsync());
        }

        public async Task<IActionResult> ManageCampaigns()
        {
            var movies = await _context.Movies.Where(m => m.IsOnSale == true).ToListAsync();
            DiscountViewModel discountViewModel = new DiscountViewModel
            {
                MoviesOnSale = movies
            };
            return View(discountViewModel);
        }

        public IActionResult NewCampaign()
        {
            DiscountViewModel discountViewModel = new DiscountViewModel
            {
                AllMovies = _context.Movies.ToList(),
                MoviesOnSale = _context.Movies.Where(m => m.IsOnSale == true).ToList()
            };
            return View(discountViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCampaign(Movie movie)
        {
            var selectedMovie = await _context.Movies.FindAsync(movie.Id);

            if (selectedMovie == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    selectedMovie.IsOnSale = true;
                    selectedMovie.Discount = movie.Discount;
                    decimal discount = Convert.ToDecimal(selectedMovie.Discount) / 100;
                    selectedMovie.DiscountPrice = selectedMovie.Price - ((selectedMovie.Price * discount));
                    selectedMovie.DiscountStart = movie.DiscountStart;
                    selectedMovie.DiscountEnd = movie.DiscountEnd;

                    _context.Update(selectedMovie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(selectedMovie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ManageCampaigns));
            }
            return View(selectedMovie);
        }

        public async Task<IActionResult> Campaigns()
        {
            var movies = await _context.Movies.Where(m => m.DiscountStart != null).ToListAsync();
            return View(movies);
        }

        public async Task<IActionResult> DeleteCampaign(Movie movie)
        {
            if (movie == null)
            {
                return NotFound();
            }

            var selectedMovie = await _context.Movies.FindAsync(movie.Id);

            selectedMovie.IsOnSale = false;
            selectedMovie.Discount = null;
            selectedMovie.DiscountPrice = null;
            selectedMovie.DiscountStart = null;
            selectedMovie.DiscountEnd = null;

            _context.Update(selectedMovie);
            _context.SaveChanges();

            return RedirectToAction("ManageCampaigns");
        }

        public async Task<IActionResult> ManageStock()
        {
            return View(await _context.Movies.ToListAsync());
        }

        public async Task<IActionResult> ManageStockIndividually(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(i => i.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        public async Task<IActionResult> IncreaseInStock(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(i => i.Id == id);
            if (movie == null)
            {
                NotFound();
            }
            else
            {
                movie.InStock++;
            }

            _context.SaveChanges();
            return RedirectToAction("ManageStockIndividually", movie);
        }

        public async Task<IActionResult> DecreaseInStock(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(i => i.Id == id);
            if (movie == null)
            {
                NotFound();
            }
            else
            {
                if (movie.InStock <= 0)
                {
                    ModelState.AddModelError("", "Can not be less than 0");
                }
                else
                {
                    movie.InStock--;
                }

            }

            _context.SaveChanges();
            return RedirectToAction("ManageStockIndividually", movie);
        }

        public async Task<IActionResult> TopTenMovies()
        {
            var moviesInDB = await _context.Movies.ToListAsync();
            Dictionary<Movie, int> movieOrders = new Dictionary<Movie, int>();

            foreach (var movie in moviesInDB)
            {
                var amountOfOrders = (from o in _context.OrderDetails
                                      join m in _context.Movies on o.MovieId equals m.Id
                                      where m.Id == movie.Id
                                      select o.OrderId).Count();

                movieOrders.Add(movie, amountOfOrders);
            }

            var orders = movieOrders.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            List<Movie> topMovies = new List<Movie>();
            int count = 0;

            foreach (var item in orders)
            {
                topMovies.Add(item.Key);
                count++;

                if (count >= 10)
                {
                    break;
                }
            }

            return View(topMovies);
        }

        public async Task<IActionResult> PurchaseLog()
        {
            return View(await _context.Orders.ToListAsync());
        }
    }
}
