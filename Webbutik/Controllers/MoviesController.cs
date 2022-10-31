using System;
using System.Collections.Generic;
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
        public async Task<IActionResult> Index()
        {
            var list = await FakeMovies.GetMoviesFromApi();
            if (!IsUpdated)
            {
                await Populate(list);
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
                Console.WriteLine("updated");
            }
            await _context.SaveChangesAsync();
        }

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

            return PartialView("components//_movieMovieDetails", movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        public ViewResult AllMovies(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

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
                movies = movies.Where(m => m.Title.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    movies = movies.OrderByDescending(m => m.Title);
                    break;
                case "Date":
                    movies = movies.OrderBy(m => m.ReleaseDate);
                    break;
                case "date_desc":
                    movies = movies.OrderByDescending(m => m.ReleaseDate);
                    break;
                default:  // Name ascending 
                    movies = movies.OrderBy(m => m.Title);
                    break;
            }

            int pageSize = 20;
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
                    // TODO: Add price

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


        public async Task<IActionResult> PurchaseLog()
        {
            return View(await _context.Orders.ToListAsync());
        }


        public ViewResult Dashboard()
        {
            return View();
        }

        public ViewResult Currency()
        {
            return View();
        }
    }
}
