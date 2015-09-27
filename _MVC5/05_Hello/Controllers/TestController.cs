using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _05_Hello.Models;
using _05_Hello.ViewModel;

namespace _05_Hello.Controllers
{

   public class TestController : Controller
   {

      public ActionResult GetView() {
         PracownikListViewModel pracListViewModel = new PracownikListViewModel();
         PracownikBusinessLayer pracBl           = new PracownikBusinessLayer();
         List<Pracownik> pracownicy              = pracBl.PobierzPracownikow();
         List<PracownikViewModel> pracViewModels = new List<PracownikViewModel>();

         foreach (Pracownik emp in pracownicy) {
            PracownikViewModel pracViewModel = new PracownikViewModel();
            pracViewModel.Pracownik          = emp.Imie +" "+emp.Nazwisko;
            pracViewModel.Pensja             = emp.Pensja.ToString("C");
            pracViewModel.PensjaKolor        = emp.Pensja > 15000 ? "yellow": "green";
            pracViewModels.Add(pracViewModel);
         }
         pracListViewModel.Pracownicy = pracViewModels;
         pracListViewModel.Uzytkownik = "Admin";         

         return View("MyView", pracListViewModel);
      }

      public ActionResult GetStronglyTypedView() {
         Pracownik prac = NewEmployee();
         ViewData["Pracownik"] = prac;
         return View("MyStronglyTypedView", prac);
      }

      public ActionResult GetViewBag() {
         Pracownik prac = NewEmployee();
         ViewBag.Pracownik = prac;
         return View("MyViewBag");
      }

      public ActionResult GetViewData() {
         Pracownik prac = NewEmployee();
         ViewData["Pracownik"] = prac;
         return View("MyViewData");
      }

      private Pracownik NewEmployee() {
         Pracownik prac = new Pracownik();
         prac.Imie = "Imie";
         prac.Nazwisko = "Nazwisko";
         prac.Pensja = 2000;
         return prac;
      }

      public Klient GetCustomer() {
         Klient k = new Klient();
         k.KlientNazwa = "Klient1";
         k.Addres = "Adres1";
         return k;
      }

   }
}