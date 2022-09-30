using DevOpsShop.Model;
using DevOpsShop.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevOpsShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<Product> _products = new List<Product>
            {
                new Product { Id = "pens-3", Name = "3 whiteboard pens", Description = "3 whiteboard pens", Price = 10m, Size = ProductSize.Small },
                new Product { Id = "pens-8", Name = "8 whiteboard pens", Description = "8 whiteboard pens", Price = 30m, Size = ProductSize.Small },
                new Product { Id = "tshirt-s", Name = "Standup TShirt Size S", Description = "Standup TShirt Size S", Price = 20m, Size = ProductSize.Small },
                new Product { Id = "tshirt-m", Name = "Standup TShirt Size M", Description = "Standup TShirt Size M", Price = 20m, Size = ProductSize.Small },
                new Product { Id = "tshirt-l", Name = "Standup TShirt Size L", Description = "Standup TShirt Size L", Price = 20m, Size = ProductSize.Small },
                new Product { Id = "tshirt-xl", Name = "Standup TShirt Size XL", Description = "Standup TShirt Size XL", Price = 20m, Size = ProductSize.Small },
            };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("catalog")]
        public IActionResult Catalog()
        {
            return View (new CatalogViewModel(_products));
        }

        [Route("product/{productId}")]
        public IActionResult Product(string productId)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);

            if (product == null)
            {
                return View("Error");
            }

            return View(new ProductViewModel(product));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}