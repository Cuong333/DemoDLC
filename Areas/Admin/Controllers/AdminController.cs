using Microsoft.AspNetCore.Mvc;

namespace DemoDLC.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/admin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
