using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesDay2.Models;

namespace MoviesDay2.Controllers
{
    public class ScreenController : Controller
    {
        // GET: Screen
        MovieContext1 m = new MovieContext1();
        Screen s = new Screen();

        // GET: Theater
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View(s);
        }
        [HttpPost]
        public ActionResult Create(Screen screen)
        {
            m.screens.Add(screen);
            m.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}