﻿using _05_Hello.Filtry;
using _05_Hello.Models;
using _05_Hello.ViewModel;
//using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
//using System.Web;
using System.Web.Mvc;
      
namespace _05_Hello.Controllers
{     
   public class PrzesylanieHurtoweController : AsyncController
   {  
      [FiltrNaglStopka]
      [FiltrAdmina]
      public ActionResult Index() {
         return View(new PrzeslaniePlikuViewModel());
      }

      [FiltrAdmina]
      public async Task<ActionResult> Przeslij(PrzeslaniePlikuViewModel model) {
         int t1 = Thread.CurrentThread.ManagedThreadId;
         List<Pracownik> pracownicy = 
           await Task.Factory.StartNew<List<Pracownik>>(()=>PobierzPracownikow(model));
         int t2 = Thread.CurrentThread.ManagedThreadId;
         PracownikBusinessLayer bl = new PracownikBusinessLayer();
         bl.PrzeslijPracownikow(pracownicy);
         return RedirectToAction("Index", "Pracownik");
      }
         
      private List<Pracownik> PobierzPracownikow(PrzeslaniePlikuViewModel model) {
         List<Pracownik> pracownicy = new List<Pracownik>();
         StreamReader csvRdr = new StreamReader(model.przeslijPlik.InputStream);
         csvRdr.ReadLine();  //Odczytaj pierszy wiersz jako nagłówek;
         while (!csvRdr.EndOfStream) {
            var line = csvRdr.ReadLine();
            var values = line.Split(','); // wartości rozdzielone przecinkiem
            Pracownik p = new Pracownik();
            p.Imie = values[0];
            p.Nazwisko = values[1];
            p.Pensja = int.Parse(values[2]);
            pracownicy.Add(p);
         }
         return pracownicy;
      }


   }
}