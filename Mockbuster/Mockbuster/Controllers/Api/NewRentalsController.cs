using Mockbuster.Dtos;
using Mockbuster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mockbuster.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // Optimistic validation, nonpublic api
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            Customer customerInDb = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable <= 0)
                    return BadRequest("movie is not available:" + movie.Name);

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customerInDb,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

        // Defensive validation for public api
        [HttpPost]
        public IHttpActionResult CreateNewRentalDefensiveValidation(NewRentalDto newRental)
        {

            if (newRental.MovieIds.Count == 0)
                return BadRequest("No movie Ids have been given.");

            Customer customerInDb = _context.Customers.SingleOrDefault(
                c => c.Id == newRental.CustomerId);

            if (customerInDb == null)
                return BadRequest("CustomerId is not valid");

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != newRental.MovieIds.Count)
                return BadRequest("One or more MovieIds are not valid");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("movie is not available:" + movie.Name);

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customerInDb,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
