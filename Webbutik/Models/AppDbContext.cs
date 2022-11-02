using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Webbutik.Models
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt){}

        public DbSet<User> Users  { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            for (int i = 1; i < 51; i++)
            {
                modelBuilder.Entity<Movie>().HasData(new Movie
                {
                    Id = i,
                    ImdbId = $"ImDbId {i}",
                    Title = $"Title {i}",
                    Description = $"Description {i}",
                    ImageUrl = $"ImageUrl {i}",
                    ReleaseDate = $"ReleaseDate {i}",
                    Stars = $"Stars {i}",
                    ImDbRating = $"ImDbRating {i}",
                    ContentRating = $"ContentRating {i}",
                    RunTimeStr = $"RunTimeStr {i}",
                    Genres = $"Genres {i}",
                    //Writers = $"Writers {i}",
                    Directors = $"Directors {i}",
                    IsOnSale = true,
                    Discount = 25,
                    InStock = 1
                });
            }            
        }
    }
}
