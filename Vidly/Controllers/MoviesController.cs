using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new List<Movie>
            {
                new Movie { Name = "Shrek" },

                new Movie { Name= "Wall E" }

            };
            var customers = new List<Customer>
            {
                 new Customer { Name = "Tino" },
                 new Customer { Name= "Tanaka" },

            };


            var viewModel = new RandomMovieViewModel
            {
               Movie = movie,
               Customers = customers
            };
            return View(viewModel);

            //return Content("Hello User");
            //return HttpNotFound();
            //return new EmptyResult();

            //return RedirectToAction("Index", "Home",new { page=1,Sortby="name"});
        }

        public ActionResult Movie()
        {
            var movie = new List<Movie>
            {
                new Movie { Name = "Shrek" },

                new Movie { Name= "Wall E" }

            };


            var viewModel = new RandomMovieViewModel
            {
                Movie = movie
            };
            return View(viewModel);
        }


        public ActionResult Edit(int id)
        {
            return Content("id=" +id);
        }


        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByreleaseDate(int year, int month)
        {

            return Content($"{year}/{month}");
        }

        


    }
}