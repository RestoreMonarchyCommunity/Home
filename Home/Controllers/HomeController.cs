using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestoreMonarchy.Home.Models;

namespace RestoreMonarchy.Home.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Plugins()
        {
            return View();
        }

        public IActionResult Discord()
        {
            return Redirect("https://discord.gg/jYMANN2");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
