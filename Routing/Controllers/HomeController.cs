using Microsoft.AspNetCore.Mvc;
using Routing.Models;
using System.Diagnostics;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Anasayfa")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Hakkinda")]
        public ActionResult About()
        {
            return View();
        }

        [Route("Haberler")]
        public IActionResult Haber(string id)
        {
            ViewBag.Id = id;
            return View();
        }

        [Route("SporGundemi")]
        public IActionResult Spor()
        {
            return View();
        }

        [Route("HavaDurumu")]
        public IActionResult Hava()
        {
            return View();
        }

        [Route("Gizlilik")]
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