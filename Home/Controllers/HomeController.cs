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

        [Route("team")]
        public IActionResult Team()
        {
            return View();
        }

        [Route("projects")]
        public IActionResult Projects()
        {
            return View();
        }

        [Route("plugins")]
        public IActionResult Plugins()
        {
            return View();
        }

        [Route("discord")]
        public IActionResult Discord()
        {
            return Redirect("https://discord.gg/Z3BWae5");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
