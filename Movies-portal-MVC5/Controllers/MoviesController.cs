﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movies_portal_MVC5.Models;

namespace Movies_portal_MVC5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Models.Movies() {Name="How To Train Your Dragon" };

            // return Content("hello world");
            // return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("index", "Home",new {pages=1,sortBy="Name" }); 
            return View(movie);
        }
    }
}