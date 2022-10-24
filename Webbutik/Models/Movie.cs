using System.ComponentModel.DataAnnotations;

namespace Webbutik.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Stars { get; set; }
        public string? Writers { get; set; }
        public string? Directors { get; set; }
        public bool? IsOnSale { get; set; }
        public int? Discount { get; set; }
        public int? InStock { get; set; }
        public int? Price { get; set; }

        //navigation prop
        public ICollection<Category>? Categories { get; set; }

    }
}
