using Webbutik.Models;

namespace Webbutik.ViewModels
{
    public class DiscountViewModel
    {
        public IEnumerable<Movie> MoviesOnSale { get; set; }
        public IEnumerable<Movie> AllMovies { get; set; }
        public Movie Movie { get; set; }
    }
}
