using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        [Route("movies/random")]
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
	            new Customer {Name = "Customer1"},
	            new Customer {Name = "Customer2"}


            };

            var viewModel = new RandomMovieViewModel()
            {
	            Movie = movie,
	            Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year+"/"+month );
        }

        [Route("movies/test")]
        public ActionResult Test()
        {
            return Content("hej !");

        }

    }
}