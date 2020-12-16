using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using ShoppingAssesment.Models;
using ShoppingAssesment.Domain;

namespace ShoppingAssesment.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        private readonly ILogger<HomeController> _logger;        

        public HomeController(IStoreRepository repo, ILogger<HomeController> logger)
        {
            repository = repo;
            _logger = logger;
        }

        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        public IActionResult Index()
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
