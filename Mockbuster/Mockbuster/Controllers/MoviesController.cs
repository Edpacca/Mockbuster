using Mockbuster.Models;
using Mockbuster.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mockbuster.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "bob", Id = 1 },
                new Customer {Name = "bill", Id = 2 }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers,
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id =" + id);
        }

        // Get: Movies
        public ActionResult Index(int? pageIndex)
        {
            var movies = GetMovies();

            var viewModel = new IndexMovieViewModel
            {
                Movies = movies,
            };

            return View(viewModel);
        }

        // Get: Movies/Released
        // ASP .NET MVC Attribute route constraints
        [Route("movies/released/{year}:regex(\\d{4})/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { Name = "Pulp Fiction", Id = 1 },
                new Movie() { Name = "Wall-e", Id = 2 },
                new Movie() { Name = "The Incredibles", Id = 3 }
            };
        }
    }
}