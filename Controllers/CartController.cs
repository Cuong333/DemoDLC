using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace DemoDLC.Controllers
{
    public class CartController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View("~/Views/Checkout/Index.cshtml");
        }
    }
}
