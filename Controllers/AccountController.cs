using DemoDLC.Data;
using DemoDLC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System;

namespace DemoDLC.Controllers
{
    public class AccountController : Controller
    {
        DemoDlcContext db = new DemoDlcContext();

        // Login GET
        [HttpGet]
        public IActionResult Login()
        {
            // If the user is already logged in, redirect to the home page
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Index", "Home");
            }

            // If the user is not logged in, show the login page
            return View();
        }

        // Login POST
        [HttpPost]
        public IActionResult Login(Customer customer)
        {
            // If the user is already logged in, redirect to the home page
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Index", "Home");
            }

            // Find the customer in the database using the provided username and password
            var cus = db.Customers.SingleOrDefault(x => x.Username == customer.Username && x.Password == customer.Password);

            // Check if the customer exists
            if (cus != null)
            {
                // Check if the Username is not null or empty
                if (!string.IsNullOrEmpty(cus.Username))
                {
                    // Store the username in session
                    HttpContext.Session.SetString("Username", cus.Username);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Handle the case where Username is null or empty
                    ViewBag.ErrorMessage = "Username is invalid.";
                    return View();
                }
            }

            // If no matching customer is found, display an error message
            ViewBag.ErrorMessage = "Invalid username or password.";
            return View();
        }

        // Register GET
        [HttpGet]
        public IActionResult Register()
        {
            // If the user is already logged in, redirect to the home page
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Index", "Home");
            }

            // If the user is not logged in, show the registration page
            return View();
        }

        // Check if the customer already exists
        private bool CustomerExists(string userName)
        {
            return db.Customers.Any(e => e.Username == userName);
        }

        // Register POST
        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            try
            {
                // Check if the model is valid
                if (ModelState.IsValid)
                {
                    // Check if the username already exists
                    if (!CustomerExists(customer.Username))
                    {
                        // If everything is valid, add the customer
                        db.Customers.Add(customer);
                        db.SaveChanges();

                        // Check if the Username is not null or empty
                        if (!string.IsNullOrEmpty(customer.Username))
                        {
                            // Store the username in session
                            HttpContext.Session.SetString("Username", customer.Username);
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            // Handle the case where Username is null or empty
                            ModelState.AddModelError("", "Username cannot be null.");
                            return View(customer);
                        }
                    }
                    else
                    {
                        // If the username already exists, show an error
                        ModelState.AddModelError("", "Username already exists!");
                    }
                }
                return View(customer);
            }
            catch (Exception ex)
            {
                // Handle any other errors and show an appropriate message
                ModelState.AddModelError("", "An error occurred while processing your request. Please try again later.");
                return View(customer);
            }
        }
    }
}
