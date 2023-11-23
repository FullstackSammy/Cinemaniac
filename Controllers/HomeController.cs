using Cinemaniac.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// Controller innehåller HTTP endpoints. Som reperesenterar olika URL.

namespace Cinemaniac.Controllers
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
            _logger.LogInformation("Hello index!!!!!!!");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Hello privacy!!!!!!!");
            return View();
        }

        public IActionResult About()
        {
            _logger.LogInformation("Hello About!!!!!!!");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
