using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _05_Hello.Models;
using _05_Hello.ViewModel;
using _05_Hello.Filtry;

namespace _05_Hello.Controllers
{

   public class PracownikController : Controller
   {

      // zamiast autoryzacji na poziomie kontrolera dodałem globalną 
      //    w FilterConfig w metodzie RegisterGlobalFilters przez wpis 
      //    filters.Add(new AuthorizeAttribute());
      // [Authorize] 
      [FiltrNaglStopka]      //25 
      public ActionResult Index()
      {
         PracownikListViewModel pracListViewModel = new PracownikListViewModel();

         PracownikBusinessLayer pracBl = new PracownikBusinessLayer();
         List<Pracownik> pracownicy = pracBl.PobierzPracownikow();
         List<PracownikViewModel> pracViewModels = new List<PracownikViewModel>();

         foreach (Pracownik prac in pracownicy)
         {
            PracownikViewModel pracViewModel = new PracownikViewModel();
            pracViewModel.Pracownik = prac.Imie + " " + prac.Nazwisko;
            pracViewModel.Pensja = prac.Pensja.ToString(); //prac.Pensja.ToString("C");
            pracViewModel.PensjaKolor = prac.Pensja > 15000 ? "yellow" : "green";
            pracViewModels.Add(pracViewModel);
         }
         pracListViewModel.Pracownicy = pracViewModels;
         return View("Index",pracListViewModel);
      }

      [FiltrAdmina]                                   //23b
      [FiltrNaglStopka]                               //25 
      public ActionResult Dodaj() {
         //return View("DodajPrac", new DodajPracViewModel());    // -25
         DodajPracViewModel dodajListVM = new DodajPracViewModel();
         //dodajListVM.NazwaUsera = User.Identity.Name.ToString();
         //dodajListVM.StopkaDane = new StopkaViewModel();
         //dodajListVM.StopkaDane.NazwaFirmy = "StepByStepSchools";//Can be set to dynamic value
         //dodajListVM.StopkaDane.Rok = DateTime.Now.Year.ToString();
         return View("DodajPrac", dodajListVM);
      }


      [FiltrAdmina]                                   //23b
      [FiltrNaglStopka]                               //25 
      public ActionResult Zapisz(Pracownik p, string bnSubmit) {
         switch (bnSubmit) {
            case "Zapisz pracownika":
               if (ModelState.IsValid) {
                  PracownikBusinessLayer pracBl = new PracownikBusinessLayer();
                  pracBl.Zapisz(p);
                  return RedirectToAction("Index");
               }
               else {
                  DodajPracViewModel vm = new DodajPracViewModel();
                  vm.Imie = p.Imie;
                  vm.Nazwisko = p.Nazwisko;
                  vm.Pensja = ModelState["Pensja"].Value.AttemptedValue;
                  vm.StopkaDane =new StopkaViewModel();

                  vm.StopkaDane = new StopkaViewModel();
                  vm.StopkaDane.NazwaFirmy = "StepByStepSchools";//Can be set to dynamic value
                  vm.StopkaDane.Rok = DateTime.Now.Year.ToString();
                  vm.NazwaUsera = User.Identity.Name;
                  return View("DodajPrac",vm);
               }
            case "Cancel":
               return RedirectToAction("Index");
         }
         return new EmptyResult();
      }

      //23
      public ActionResult Pobierz_DodajPracLink() {
         if (Convert.ToBoolean(Session["CzyAdmin"])) {
            return PartialView("DodajPracLink");
         }
         else {
            return new EmptyResult();
         }
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