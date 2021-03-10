using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment_5_real.Infrastructure;
using assignment_5_real.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace assignment_5_real.Pages
{
    //Set up the important model for the self contanted Razer page
    public class CartModel : PageModel
    {
        private ILibroRepository _repository;

        public CartModel (ILibroRepository repository, Cart cartService)
        {
            _repository = repository;
            Cart = cartService;
        }
        
        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        //for get methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        //the following two methods are for post methods
        //the first is for adding things to the cart
        public IActionResult OnPost (long bookId, string returnUrl)
        {
            Libro libro = _repository.Libros.FirstOrDefault(l => l.BookID == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(libro, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
        //this method is for deleting things from the cart
        public IActionResult OnPostRemove (long bookId, string returnUrl)
        {
            Libro libro = _repository.Libros.FirstOrDefault(l => l.BookID == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.RemoveLine(libro);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
