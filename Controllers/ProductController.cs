using Microsoft.AspNetCore.Mvc;
using DemoDLC.Models;
namespace DemoDLC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var listProduct = new List<Product>();
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View("~/Views/Checkout/ProductDetail.cshtml");
        }
    }
}
