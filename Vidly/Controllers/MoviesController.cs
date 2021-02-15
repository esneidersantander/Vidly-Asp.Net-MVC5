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
            var movie = new Movie() { Name = "Sherek!" };
            var customers = new List<Customer>
            {
                new Customer { Name= "customer 1"},
                new Customer { Name= "customer 2"},
            };

            var viewModel = new RandomMovieViewModel
            { 
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        [Route("movies/release/{year}/{month}:regex(\\d{2}:range(1,12))")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index() 
        {
            var movies =GetMovies();
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
    }
}