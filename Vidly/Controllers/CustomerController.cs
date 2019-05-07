using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Frank Jones" },
                new Customer { Name = "Rodger Clemens"}
            };
            //return Content(customers[1].Name);
            var viewModel = new CustomerIndexViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
    }
}