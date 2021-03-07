using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfCore_Project.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
            // _context.Products.Add(product);
            // _context.Products.Add(product2);
            // _context.Products.Add(product3);
            var i=_context.Products.FirstOrDefault(x=>x.Id==6);
            //i.IsDeleted = true;
            //i.Restore();
            //_context.Remove(i);
            var umy = _context.Entry(i).State;
            _context.SaveChanges();
            var products = _context.Products.Where(x => x.IsDeleted == false).ToList();
            var product = DisplayStates(_context.ChangeTracker.Entries());
            var o =_context.ChangeTracker.Entries();
            var e = _context.ChangeTracker.Entries();
            return View(products);
            
        }

        private object DisplayStates(IEnumerable<EntityEntry> enumerable)
        {
            List<string> result = new List<string>();
            foreach (var item in enumerable)
            {
                result.Add($"Entiy:{item.GetType().Name} - State: {item.State} - {item.Properties}") ;
            }
            return result;
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
