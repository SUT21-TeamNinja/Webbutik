using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webbutik.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? ReleaseDate { get; set; }
        public string? Stars { get; set; }
        public string? ImDbRating { get; set; }
        public string? ContentRating { get; set; }
        public string? RunTimeStr { get; set; }
        public string? Genres { get; set; }
        public string? ImdbId { get; set; }
        public string? Directors { get; set; }
        public bool? IsOnSale { get; set; }
        public int? Discount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountPrice { get; set; }
        public DateTime? DiscountStart { get; set; }
        public DateTime? DiscountEnd { get; set; }
        public int? InStock { get; set; }
        public int? Price { get; set; }

        //navigation prop
        public ICollection<Category>? Categories { get; set; }

    }
}
