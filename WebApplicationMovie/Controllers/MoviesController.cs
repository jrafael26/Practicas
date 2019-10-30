using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMovie.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            List<Models.Movies> model = new List<Models.Movies>();
            var movies = new List<Models.Movies>
            {
                new Models.Movies { Id=1, Title="Joker 2019", Year=2019},
                new Models.Movies { Id= 2, Title   = "Eli", Year=2019 },
                new Models.Movies { Id= 2, Title   = "Sabrina", Year=2018 },
                new Models.Movies { Id= 2, Title   = "Rapidos y Furiosos 5", Year=2011 },
                new Models.Movies { Id= 2, Title   = "Los 4 Fantásticos", Year=2015 },

            };

            model = movies;
            return View(model);
        }

        public ActionResult Details()
        {
            List<Models.Customers> model = new List<Models.Customers>();
            var customers = new List<Models.Customers>
            {
                new Models.Customers{ Id=1, Name="Juan Perez"},
                new Models.Customers { Id= 2, Name= "Mario Kart" },
                new Models.Customers{ Id=1, Name="Alicia Rodríguez"},
                new Models.Customers { Id= 2, Name= "Pedro Pablo Gil" }

            };

            model = customers;
            return View(model);
        }
         /*public ActionResult Details()
        {
            var model = new List<Models.Customers>
            {
                new Models.Customers{ Id=1, Name="Juan Perez"},
                new Models.Customers { Id= 2, Name= "Mario Brothers" }

            };
            return View(model);

        }*/

    }
}