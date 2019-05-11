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
        public Customer Customer { get; set; }
        public int Id { get; set; }
    }
}