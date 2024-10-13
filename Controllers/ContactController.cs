using Microsoft.AspNetCore.Mvc;

namespace DemoDLC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
