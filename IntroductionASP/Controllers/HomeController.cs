using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IntroductionASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        // GET: /<controller>/Index
        // GET: ""
        public IActionResult Index(int id)
        {
            //return $"In HomeController.Index, id is {id}";

            return Content("<html><head></head><body><h1>We prefer Razor</h1></body></html>", "text/html");
        }

        public string Contact()
        {
            return "In HomeController.Index";
        }

        [HttpGet]
        public IActionResult Time()
        {
            return View();
        }
    }
}
