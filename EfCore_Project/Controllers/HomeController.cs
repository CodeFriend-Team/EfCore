using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfCore_Project.Models;

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
           var product = new Product("iphone 11",20000000);
            _context.Products.Add(product);
            _context.SaveChanges();
            return View();
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
