using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_test.Models;
using Vidly_test.ViewModels;

namespace Vidly_test.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
            
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customers>
            {
                new Customers { Name = "Customer 1"},
                new Customers { Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie, Customers = customers
            };
            return View(viewModel);
        }
    }
}