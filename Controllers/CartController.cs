using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using ShoppingAssesment.Domain;
using ShoppingAssesment.Domain.Entities;
using ShoppingAssesment.Models;
using ShoppingAssesment.Extension;
using Microsoft.AspNetCore.Routing;

namespace ShoppingAssesment.Controllers
{
    public class CartController : Controller
    {
        private IStoreRepository repository;
        public Cart Cart { get; set; }
        
        public CartController(IStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        //[Route("Cart/Index")]
        public IActionResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel {
                CartVM = Cart,
                ReturnUrl = returnUrl
            });
            //CartVM = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            //return View(new CartIndexViewModel
            //{
            //    CartVM = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart(),
            //    ReturnUrl = returnUrl ?? "/"
            //}); 
        }

        public ActionResult AddToCart(int productId, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(product, 1);
            //HttpContext.Session.SetJson("cart", Cart);
            return RedirectToAction("Index", new { returnUrl });
        }

        public ActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                Cart.RemoveLine(product);
                //cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        //public ActionResult AddToCart(int productId, string returnUrl)
        //{
        //    Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);
        //    if (product != null)
        //    {
        //        GetCart().AddItem(product, 1);
        //    }
        //    return RedirectToAction("Index", new { returnUrl });
        //}

        //private Cart GetCart()
        //{
        //    Cart cart = HttpContext.Session.GetJson<Cart>("cart");
        //    if (cart == null)
        //    {
        //        cart = new Cart();
        //        HttpContext.Session.SetJson("cart", cart);
        //    }
        //    return cart;
        //}
    }
}
