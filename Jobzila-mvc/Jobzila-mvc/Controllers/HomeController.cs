using Jobzila_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Jobzila_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult contact_us()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult job_listing()
        {
            return View();
        }

        public IActionResult job_search()
        {
            return View();
        }

        public IActionResult privacy()
        {
            return View();
        }

        public IActionResult terms()
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
