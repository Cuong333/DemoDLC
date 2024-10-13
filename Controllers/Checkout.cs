using Microsoft.AspNetCore.Mvc;

namespace DemoDLC.Controllers
{
    public class Checkout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
