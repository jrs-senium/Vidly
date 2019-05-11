using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            //return Content(customers[1].Name);
            var viewModel = new CustomerIndexViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var customers = _context.Customers.SingleOrDefault(c => c.Id == id);
            //var viewModel = new CustomerDetailsViewModel
            //{
            //    Customer = customers
            //};
            return View(customers);
        }


    }
}