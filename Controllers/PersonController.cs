using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> options = new List<string>();
            options.Add("Select an Option");
            options.Add("Yes");
            options.Add("No");
            ViewData["options"] = new SelectList(options);
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails (IFormCollection Form, ICollection<string> hobbies)
        {
            ViewBag.Name = Form["Name"];
            ViewBag.Gender = Form["Gender"];
            ViewBag.Hobbies = hobbies;
            ViewBag.Options = Form["Options"];
            return View("Display");
        }
    }
}
