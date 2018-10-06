using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movies_portal_MVC5.Models;

namespace Movies_portal_MVC5.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}