using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practica_1.Models;

namespace Practica_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Vista()
            {
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
