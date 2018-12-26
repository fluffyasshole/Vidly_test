using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_test.Controllers;
using Vidly_test.Models;

namespace Vidly_test.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customers> Customers { get; set; }
    } 
}