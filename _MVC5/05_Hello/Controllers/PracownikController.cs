using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _05_Hello.Models;
using _05_Hello.ViewModel;

namespace _05_Hello.Controllers
{

   public class PracownikController : Controller
   {

      public ActionResult Index()
      {
         PracownikListViewModel pracListViewModel = new PracownikListViewModel();
         PracownikBusinessLayer pracBl = new PracownikBusinessLayer();
         List<Pracownik> pracownicy = pracBl.PobierzPracownikow();
         List<PracownikViewModel> pracViewModels = new List<PracownikViewModel>();

         foreach (Pracownik emp in pracownicy)
         {
            PracownikViewModel pracViewModel = new PracownikViewModel();
            pracViewModel.Pracownik = emp.Imie + " " + emp.Nazwisko;
            pracViewModel.Pensja = emp.Pensja.ToString("C");
            pracViewModel.PensjaKolor = emp.Pensja > 15000 ? "yellow" : "green";
            pracViewModels.Add(pracViewModel);
         }

         pracListViewModel.Pracownicy = pracViewModels;
         return View("Index",pracListViewModel);
      }

      public ActionResult Dodaj() {
         return View("DodajPrac");
      }

      public ActionResult Zapisz(Pracownik p, string bnSubmit) {
         switch (bnSubmit) {
            case "Zapisz pracownika":
               if (ModelState.IsValid) {
                  PracownikBusinessLayer pracBl = new PracownikBusinessLayer();
                  pracBl.Zapisz(p);
                  return RedirectToAction("Index");
               }
               else {
                        return View("DodajPrac");
               }
            case "Cancel":
               return RedirectToAction("Index");
         }
         return new EmptyResult();
      }

      //public ActionResult Zapisz() {
      // In this situation we have following three solutions
      // 1: Inside action method, retrieve posted values using Request.Form 
      //    syntax and manually construct the Model object as follows.
   
      //   Pracownik p = new Pracownik();
      //   p.Imie = Request.Form[""]

      //   switch (bnSubmit) {
      //      case "Zapisz pracownika":
      //         return Content(p.Imie + "|" + p.Nazwisko + "|" + p.Pensja);
      //      case "Cancel":
      //         return RedirectToAction("Index");
      //      default:
      //         return Content("Pusty bnSubmit...");
      //   }
      //   return new EmptyResult();
      //}

      //public ActionResult Zapisz(Pracownik p, string bnSubmit) {
      //   switch (bnSubmit) {
      //      case "Zapisz pracownika":
      //         return Content(p.Imie + "|" + p.Nazwisko + "|" + p.Pensja);
      //      case "Cancel":
      //         return RedirectToAction("Index");
      //      default:
      //         return Content("Pusty bnSubmit...");
      //   }
      //   return new EmptyResult();
      //}





      public ActionResult GetStronglyTypedView()
      {
         Pracownik prac = NowyPracownik();
         ViewData["Pracownik"] = prac;
         return View("MyStronglyTypedView", prac);
      }

      public ActionResult GetViewBag() {
         Pracownik prac = NowyPracownik();
         ViewBag.Pracownik = prac;
         return View("MyViewBag");
      }

      public ActionResult GetViewData() {
         Pracownik prac = NowyPracownik();
         ViewData["Pracownik"] = prac;
         return View("MyViewData");
      }

      private Pracownik NowyPracownik() {
         Pracownik prac = new Pracownik();
         prac.Imie = "Imie";
         prac.Nazwisko = "Nazwisko";
         prac.Pensja = 2000;
         return prac;
      }

      public Klient NowyKlient() {
         Klient k = new Klient();
         k.KlientNazwa = "Klient1";
         k.Addres.Miasto = "Poznan";
         k.Addres.Powiat = "wielkopolski";
         return k;
      }

   }
}