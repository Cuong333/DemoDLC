using Microsoft.AspNetCore.Mvc;

namespace DemoDLC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryIndex()
        {
            return View();
        }
    }
}
