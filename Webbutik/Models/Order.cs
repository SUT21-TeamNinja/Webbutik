namespace Webbutik.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? User { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public int? OrderTotal { get; set; }
        public DateTime? OrderDate { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
