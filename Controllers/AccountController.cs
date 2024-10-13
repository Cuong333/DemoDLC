using DemoDLC.Data;
using DemoDLC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoDLC.Controllers
{
    
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
