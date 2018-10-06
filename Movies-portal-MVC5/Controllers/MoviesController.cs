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
        public ActionResult Edit(int Id)
        {
            return Content("id="+Id);
        }
        //Movies
        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("PageIndex={0} & SortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year+"/"+month);
        }
    }
}