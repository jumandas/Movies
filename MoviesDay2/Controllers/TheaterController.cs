using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesDay2.Models;

namespace MoviesDay2.Controllers
{
    public class TheaterController : Controller
    {
        MovieContext m = new MovieContext();
        Theater t = new Theater();

        // GET: Theater
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View(t);
        }
        [HttpPost]
        public ActionResult Create(Theater thtr)
        {
            m.theaters.Add(thtr);
            m.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}