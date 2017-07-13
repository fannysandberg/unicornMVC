using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntroductionASP.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IntroductionASP.Controllers
{
    [Route("kunder")] //om ngn skriver kunder/hem så kommer man till route hem
    public class CustomersController : Controller
    {
        public CustomersController()
        {

        }

        [Route("home.php")] //dirigerar om så gamla urler fungerar, dvs om man har haft php innan (pratar fysiska filer)
        [Route("hem")] //går man på routern och säger 'hem' kommer man till den här actionen
        public IActionResult Index()
        {
            var customers = DataManager.GetAllCustomers();
            ViewData["Customers"] = customers;
            return View(); //metod som returnerar ett view-result. View ärvs från basklassen controller
        }

        [HttpGet] //attribut, är det post kan detta ignoreras
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // är det get kan detta ignoreras,
        public IActionResult Create(Customer customer)
        {
            return View();
        }


    }
}
