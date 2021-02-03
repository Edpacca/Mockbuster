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
        ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Edit(int id)
        {
            return Content("id =" + id);
        }

        // Get: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies;

            var viewModel = new IndexMovieViewModel
            {
                Movies = movies,
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            return View(movie);
        }

        // Get: Movies/Released
        // ASP .NET MVC Attribute route constraints
        [Route("movies/released/{year}:regex(\\d{4})/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>()
        //    {
        //        new Movie() { Name = "Pulp Fiction", Id = 1 },
        //        new Movie() { Name = "Wall-e", Id = 2 },
        //        new Movie() { Name = "The Incredibles", Id = 3 }
        //    };
        //}
    }
}