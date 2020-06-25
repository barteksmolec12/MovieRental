﻿using MovieRental.Models;
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
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
        // GET: Movies
        //[Route("customers")]
        //public ActionResult Random()
        //{

        //    var movie = new Movie() { Name = "Shrek" };
        //    var customers = new List<Customer>
        //    {
        //        new Customer {Name = "Customer1"},
        //        new Customer {Name = "Customer2"}


        //    };

        //    var viewModel = new RandomMovieViewModel()
        //    {
        //     Movie = movie,
        //     Customers = customers
        //    };

        //    return View(viewModel);
        //}

        //[Route("movies/released/{year}/{month}")]
        //public ActionResult ByReleaseYear(int year, int month)
        //{
        //    return Content(year+"/"+month );
        //}


    }
}