using Webbutik.Models;

namespace Webbutik.ViewModels
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public int TotalItems { get; set; }
        public int? CartTotal { get; set; }
    }
}
