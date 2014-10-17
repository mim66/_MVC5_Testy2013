using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmyMvc.Models;

namespace FilmyMvc.Controllers
{
    public class FilmyController : Controller
    {
        private FilmContext db = new FilmContext();


        // GET: /Filmy/Szukaj/
        public ActionResult Szukaj(string _kategoria, string _szukaj) {
           var listaKategorii = new List<string>();

           var zapytanie = from d in db.Filmy
                          orderby d.Kategoria
                          select d.Kategoria;
           listaKategorii.AddRange(zapytanie.Distinct());
           ViewBag._kategoria = new SelectList(listaKategorii);

           var filmy = from m in db.Filmy
                        select m;

           if (!String.IsNullOrEmpty(_szukaj)) {
              filmy = filmy.Where(s => s.Tytul.Contains(_szukaj));
           }

           if (string.IsNullOrEmpty(_kategoria))
              return View(filmy);
           else {
              return View(filmy.Where(x => x.Kategoria == _kategoria));
           }

           #region old
           //var filmy = from f in db.Filmy
           //            select f;
           //if (!String.IsNullOrEmpty(_szukaj)) {
           //   filmy = filmy.Where(s => s.Tytul.Contains(_szukaj));
           //}
           //return View(filmy);
           #endregion
        }
        //[HttpPost]
        //public string Szukaj(FormCollection fc, string szukaj) {
        //   return "<h3> Z [HttpPost]Szukaj: " + szukaj + "</h3>";
        //}

        // GET: /Filmy/
        public ActionResult Index()
        {
            return View(db.Filmy.ToList());
        }


        //
        // GET: /Filmy/Detale/5
        public ActionResult Detale(int id = 0)
        {
            Film film = db.Filmy.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: /Filmy/Nowy
        public ActionResult Nowy()
        {
            return View();
        }
        // POST: /Filmy/Nowy
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Nowy(Film film)
        {
            if (ModelState.IsValid)
            {
                db.Filmy.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(film);
        }

        //
        // GET: /Filmy/Edycja/5
        public ActionResult Edycja(int id = 0)
        {
            Film film = db.Filmy.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }
        // POST: /Filmy/Edycja/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edycja(Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(film);
        }

        //
        // GET: /Filmy/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Film film = db.Filmy.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        //
        // POST: /Filmy/Delete/5

        [HttpPost, ActionName("Delete")]
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
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}