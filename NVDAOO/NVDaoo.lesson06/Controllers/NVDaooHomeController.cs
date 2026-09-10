using Microsoft.AspNetCore.Mvc;
using NVDaoo.lesson06.Models;
using System.Diagnostics;

namespace NVDaoo.lesson06.Controllers
{
    public class NVDaooHomeController : Controller
    {
        private readonly ILogger<NVDaooHomeController> _logger;

        public NVDaooHomeController(ILogger<NVDaooHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
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
