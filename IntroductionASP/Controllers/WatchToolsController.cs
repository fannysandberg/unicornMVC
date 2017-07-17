using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntroductionASP.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IntroductionASP.Controllers
{
    public class WatchToolsController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            var viewModel = DataManager.GetAllWatchTools();
   
            return View(viewModel);
        }
    }
}
