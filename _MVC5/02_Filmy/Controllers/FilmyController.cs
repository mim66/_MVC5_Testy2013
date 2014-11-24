using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _02_Filmy.Models;

namespace _02_Filmy.Controllers
{
    public class FilmyController : Controller
    {
        private FilmyDBContext db = new FilmyDBContext();

        // GET: Filmy
        public ActionResult Index()
        {
            return View(db.Filmy.ToList());
        }

        // GET: Filmy/Detale/5
        public ActionResult Detale(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Filmy.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Filmy/Nowy
        public ActionResult Nowy()
        {
            return View();
        }

        // POST: Filmy/Nowy
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Nowy([Bind(Include = "ID,Tytul,DataWydania,Kategoria,Cena")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Filmy.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(film);
        }

        // GET: Filmy/Edycja/5
        public ActionResult Edycja(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Filmy.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Filmy/Edycja/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edycja([Bind(Include = "ID,Tytul,DataWydania,Kategoria,Cena")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(film);
        }

        // GET: Filmy/Usun/5
        public ActionResult Usun(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Filmy.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Filmy/Usun/5
        [HttpPost, ActionName("Usun")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Filmy.Find(id);
            db.Filmy.Remove(film);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
