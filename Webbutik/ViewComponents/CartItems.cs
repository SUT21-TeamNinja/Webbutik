using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Webbutik.Models;
using Webbutik.ViewModels;

namespace Webbutik.ViewComponents
{
    public class CartItems : ViewComponent
    {
        
        private readonly Cart _cart;

        public CartItems(Cart cart) => _cart = cart;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            _cart.CartItems = await _cart.GetCartItemsAsync();
            return View(new CartViewModel
            {
                Cart = _cart,
                Total = await _cart.GetTotalItemsInCartAsync()
            });
        }


    }
}
