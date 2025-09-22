using System.Diagnostics;
using DAWAR.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAWAR.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Quality()
        {
            return View();
        }
        public IActionResult Washers()
        {
            return View();
        }
        public IActionResult Bolts()
        {
            return View();
        }
        public IActionResult Nuts()
        {
            return View();
        }

    }
}
