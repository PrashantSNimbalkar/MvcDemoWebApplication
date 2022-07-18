using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product>()
            {
                new Product{Id=1, Name="Lenovo laptop", Price=23000},
                new Product{Id=2, Name = "Dell laptop", Price = 30000 }
            };
            ViewBag.ProductList = plist;
            return View();
        }
        [HttpGet]   //by deafault it is HttpGet
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            ViewBag.Id = form["pid"];
            ViewBag.Name = form["pname"];
            ViewBag.Price = form["price"];

            return View("Details");



        }  
    }
}