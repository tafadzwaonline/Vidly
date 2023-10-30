using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customer()
        {
            var customers = new List<Customer>
            {
                 new Customer { Name = "John Smith" },
                 new Customer { Name= "Marry Williams" },

            };


            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {

            string customers = string.Empty;

 
            if (id == 1)
            {
                customers = "John Smith";
            }
            else if (id == 2)
            {
                customers = "Marry Williams";
            }
            else
            {
                return HttpNotFound();
            }

            var viewModel = new Customer
            {
                Name = customers
            };
            return View(viewModel);

        }
       
    }
}