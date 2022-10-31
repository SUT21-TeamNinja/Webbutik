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
            return View(await _context.Movies.ToListAsync());
        }

        
    }
}
