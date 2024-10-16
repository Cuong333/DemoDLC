using DemoDLC.Data;
using DemoDLC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoDLC.Controllers
{
    public class AccountController : Controller
    {
       
        DemoDlcContext db = new DemoDlcContext();
    
        [HttpGet]
        public IActionResult Login()
        {
            // Nếu đã đăng nhập, chuyển hướng tới trang chính
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Index", "Home");
            }

            // Nếu chưa đăng nhập, hiển thị trang login
            return View();
        }

        [HttpPost]
        public IActionResult Login(Customer customer)
        {
            // Nếu đã đăng nhập, chuyển hướng tới trang chính
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Index", "Home");
            }

            // Kiểm tra tài khoản người dùng
            var cus = db.Customers
                        .SingleOrDefault(x => x.Username == customer.Username && x.Password == customer.Password);

            if (cus != null)
            {
                // Nếu đúng thông tin, lưu username vào session
                HttpContext.Session.SetString("Username", cus.Username);
                return RedirectToAction("Index", "Home");
            }

            // Nếu không tìm thấy tài khoản phù hợp, hiển thị thông báo lỗi
            ViewBag.ErrorMessage = "Invalid username or password.";
            return View();
        }

        // Register
        private bool CustomerExists(string userName)
        {
            return db.Customers.Any(e => e.Username == userName);
        }
        [HttpGet]
        public IActionResult Register()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!CustomerExists(customer.Username))
                    {
                        db.Customers.Add(customer);
                        db.SaveChanges();
                        HttpContext.Session.SetString("UserName", customer.Username);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Username already exists!");
                    }
                }
                return View(customer);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while processing your request. Please try again later.");
                return View(customer);
            }
        }
    }
}
