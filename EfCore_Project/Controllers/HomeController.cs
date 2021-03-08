using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EfCore_Project.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

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
            //var product1 = new Product("Lenovo LC3", 350000);
            //var product2 = new Product("Asus book", 200000);
            //ViewData["count"] = _context.Products.Count();
            //_context.Products.Add(product1);
            //_context.Products.Add(product2);
            //// _context.Products.Add(product3);
            //var i=_context.Products.FirstOrDefault(x=>x.Id==6);
            //i.IsDeleted = true;
            //i.Restore();
            //_context.Remove(i);

            //var product2 = _context.Products.Find(2);
            //product2.Restore();
            //var product4 = _context.Products.Find(3);
            //product4.Restore();

            _context.SaveChanges();
            var products = _context.Products.Where(x => x.IsDeleted == false).ToList();
            var product = DisplayStates(_context.ChangeTracker.Entries());
            var o =_context.ChangeTracker.Entries();
            var e = _context.ChangeTracker.Entries();
            return View(products);
            
        }
        public IActionResult details(int id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }
        public void Delete(int id)
        {

            var product = _context.Products.Find(id);
            product.IsDeleted = true;
            _context.SaveChanges();
        }
        public IActionResult RecycleBeen()
        {
            var product = _context.Products.Where(p=>p.IsDeleted == true).ToList();
            return View(product);
            
        }
        public void Restore(int id)
        {

            var product = _context.Products.Find(id);
            product.Restore();
            _context.SaveChanges();
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
