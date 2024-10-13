using Microsoft.AspNetCore.Mvc;

namespace DemoDLC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
