namespace Webbutik.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string CartId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
