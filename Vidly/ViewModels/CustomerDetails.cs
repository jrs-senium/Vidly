using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using Vidly.Controllers;

namespace Vidly.ViewModels
{
    public class CustomerDetailsViewModel
    {
        public List<Customer> Customers { get; set; }
        public int Id { get; set; }
    }
}