using Microsoft.AspNetCore.Mvc;
using Webbutik.Models;
using Webbutik.ViewModels;

namespace Webbutik.ViewComponents
{
    public class CartTotal:ViewComponent
    {
        private readonly Cart _cart;

        public CartTotal(Cart cart) => _cart = cart;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            _cart.CartItems = await _cart.GetCartItemsAsync();
            return View(new CartViewModel
            {
                Cart = _cart,
                CartTotal = await _cart.GetOrderTotalAsync()
            });
        }
    }
}
