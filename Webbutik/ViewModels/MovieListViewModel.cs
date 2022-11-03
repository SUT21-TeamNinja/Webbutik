using Webbutik.Models;
using X.PagedList;

namespace Webbutik.ViewModels
{
    public class MovieListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IPagedList<Movie>? PagedMovies { get; set; }
    }
}
