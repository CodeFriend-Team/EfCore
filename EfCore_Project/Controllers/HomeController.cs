using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfCore_Project.Models;
using System.Linq;

namespace EfCore_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly  ShopContext _context;

        public HomeController(ShopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var product = new Product("Lenovo LC3",350000);
            // var product2 = new Product("Asus book", 200000);
            ViewData["count"] = _context.Products.Count();
            var products = _context.Products.ToList();
            // _context.Products.Add(product);
            // _context.Products.Add(product2);
            // _context.Products.Add(product3);
            _context.SaveChanges();
            
            return View(products);
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
