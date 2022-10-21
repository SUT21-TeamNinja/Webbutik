using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Webbutik.Models;
using Webbutik.ViewModels;

namespace Webbutik.ViewComponents
{
    public class CartItems : ViewComponent
    {
        private readonly AppDbContext _context;

        public CartItems(AppDbContext context) => _context = context;

        //public async Task<IActionResult> InvokeAsync()
        //{
        //    return View(new CartViewModel
        //    {
        //        Cart = 
        //    })
        //}


    }
}
