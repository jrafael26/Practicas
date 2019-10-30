using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMovie.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
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
    }
}