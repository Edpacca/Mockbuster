using Mockbuster.Models;
using Mockbuster.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mockbuster.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            var viewModel = new IndexCustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);

        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() {Name = "Volo Geddarm", Id = 1 },
                new Customer() {Name = "Vajra Safar", Id = 2 },
                new Customer() {Name = "Lindir the Fair", Id = 3 }
            };
        }
    }
}