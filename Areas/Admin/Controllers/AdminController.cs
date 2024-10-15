using Microsoft.AspNetCore.Mvc;
using DemoDLC.Data;
using DemoDLC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
namespace DemoDLC.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/admin")]
    public class AdminController : Controller
    {
        DemoDlcContext db =new DemoDlcContext();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        // List Product
        [Route("listProduct")]
        public IActionResult ListProduct()
        {
            var listProduct = db.Products
        .Include(p => p.Category)
        .Include(p => p.Manufacturer)
        .ToList();
         
            return View(listProduct);
        }
        // Add Product
        [Route("AddProduct")]
        [HttpGet]

        public IActionResult AddProduct()
        {
           ViewBag.CategoryId = new SelectList(db.Categories.ToList(), "CategoryId", "Name");
           ViewBag.ManufacturerId = new SelectList(db.Manufacturers.ToList(), "ManufacturerId", "Name");
            return View();
        }
        [Route("AddProduct")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid != null)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("ListProduct");
            }
            return View(product);
        }

        // Edit Product
        [Route("EditProduct")]
        [HttpGet]
        public IActionResult EditProduct(string ProductId)
        {
            // Fetch categories and manufacturers for dropdowns
            ViewBag.CategoryId = new SelectList(db.Categories.ToList(), "CategoryId", "Name");
            ViewBag.ManufacturerId = new SelectList(db.Manufacturers.ToList(), "ManufacturerId", "Name");

            // Find the product by ProductId
            var product = db.Products.Find(ProductId);
            if (product == null)
            {
                return RedirectToAction("ListProduct", "Admin");
            }

            return View(product);
        }

        [Route("EditProduct")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid != null)
            {
                db.Products.Update(product);
                db.SaveChanges();
                return RedirectToAction("ListProduct");
            }
            return View(product);
        }


        // Delete Product
        [Route("DeleteProduct")]
        [HttpGet]
        public IActionResult DeleteProduct(string ProductId)
        {
            var product = db.Products.Find(ProductId);
            if (product == null)
            {
                TempData["Message"] = "Product not found.";
                return RedirectToAction("ListProduct");
            }
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("ListProduct");
        }

        // Manamange account
        [Route("CustomerList")]
        public IActionResult CustomerList()
        {
            var accounts = db.Customers.ToList();

            return View(accounts);
        }

        //Delete account
        [Route("DeleteCustomer")]
        [HttpGet]
        public IActionResult DeleteCustomer(int CustomerId)
        {
            var customer = db.Customers.Find(CustomerId);
            if (customer == null)
            {
                TempData["Message"] = "Customer not found.";
                return RedirectToAction("CustomerList");
            }
            // Remove the customer
            db.Customers.Remove(customer);
            db.SaveChanges();

            // Set confirmation message
            TempData["ConfirmMessage"] = $"Customer '{customer.CustomerId}' has been deleted.";

            // Redirect to the list of customers
            return RedirectToAction("CustomerList");
        }

    }
}
