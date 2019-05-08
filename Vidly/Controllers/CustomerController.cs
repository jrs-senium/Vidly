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
        List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Frank Jones" , Id = 0},
                new Customer { Name = "Roger Clemens", Id = 1}
            };
        // GET: Customer
        public ActionResult Index()
        {
            //return Content(customers[1].Name);
            var viewModel = new CustomerIndexViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var viewModel = new CustomerDetailsViewModel
            {
                Customers = customers,
                Id = id
            };
            return View(viewModel);
        }


    }
}