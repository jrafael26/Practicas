using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMovies.Models;

namespace WebApplicationMovies.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            //using (ApplicationDbContext db = new ApplicationDbContext())
            //{

            //    List<Movie> lista = db.Movies.ToList();

            //    return View(lista);
            //}

            using (ApplicationDbContext db = new ApplicationDbContext())
            {

                //List<Movie> lista = db.Movies.Where(m => m.Year<2019)
                //    .ToList();

                List<Movie> lista = db.Movies.ToList();

                return View(lista);
            }

        }

        // CRUD

        public ActionResult Create()
        {

            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie model)
        {
            //Validamos el modelo

            if (!ModelState.IsValid)
                return View();

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Movies.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

        }

        public ActionResult Edit(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                Movie mov = db.Movies.Find(id);
                return View(mov);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie model)
        {

            //Validamos el modelo

            if (!ModelState.IsValid)
                return View();
            using (var db = new ApplicationDbContext())
            {
                Movie mov = db.Movies.Find(model.Id);
                mov.Title = model.Title;
                mov.Year = model.Year;
                mov.Genre = model.Genre;
                mov.Director = model.Director;
                mov.Summary = model.Summary;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Details(int id)
        {
            if (id == 0) return View();

            using (var db = new ApplicationDbContext())
            {
                Movie mov = db.Movies.Find(id);
                return View(mov);
            }
                
        }

        public ActionResult Delete (int id)
        {
            if (id == 0) return View();

            using (var db = new ApplicationDbContext())
            {
                Movie mov = db.Movies.Find(id);
                db.Movies.Remove(mov);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}