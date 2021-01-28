using Mockbuster.Models;
using Mockbuster.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace Mockbuster.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Test()
        {
            TestCustomerViewModel viewModel = new TestCustomerViewModel()
            {
                Customers = GetCustomers(),
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            return View(customer);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Name = "Volo Geddarm", Id = 1 },
                new Customer { Name = "Vajra Saffar", Id = 2 }
            };
        }
    }
}