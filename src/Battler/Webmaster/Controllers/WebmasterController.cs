using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Battler.Webmaster.Models;

namespace Battler.Webmaster.Controllers
{
    public class WebmasterController : Controller
    {
        private readonly ILogger<WebmasterController> _logger;

        public WebmasterController(ILogger<WebmasterController> logger)
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
    }
}