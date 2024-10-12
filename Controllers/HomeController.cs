using DemoDLC.Data;
using DemoDLC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoDLC.Controllers
{
    public class HomeController : Controller
    {
        DemoDlcContext db = new DemoDlcContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listProduct = db.Products.ToList();
            return View(listProduct);
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
