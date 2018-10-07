using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movies_portal_MVC5.Models;
using Movies_portal_MVC5.ViewModels;

namespace Movies_portal_MVC5.Controllers
{
    public class MoviesController : Controller
    {
        
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movies() { Name = "How To Train Your Dragon" };
            var customers = new List<Customer>
            {
                new Customer {Name="Customer 1" },
                 new Customer {Name="Customer 2" },
                  new Customer {Name="Customer 3" }
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(ViewModel);
        }
        // GET: Movies/filter by released date
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }
        //Get: Movies List
        private IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>
            {
                new Movies { Id = 1, Name = "Shrek" },
                new Movies { Id = 2, Name = "Wall-e" },
                new Movies { Id = 2, Name = "How To Train Your Dragon" }
            };
        }

       

       
    }
}