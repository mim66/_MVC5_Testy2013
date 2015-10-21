using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _05_Hello.DAL;

namespace _05_Hello.Models
{
   public class PracownikBusinessLayer
   {
      public Pracownik Zapisz(Pracownik p) { 
         MvcHelloDB dal = new MvcHelloDB();
         dal.Pracownicy.Add(p);
         dal.SaveChanges();
         return p;
      }

      public List<Pracownik> PobierzPracownikow() { 
         MvcHelloDB context = new MvcHelloDB();
         return context.Pracownicy.ToList();
         #region
         //List<Pracownik> listaPrac = new List<Pracownik>();
         //Pracownik emp = new Pracownik();
         //emp.Imie = "johnson";
         //emp.Nazwisko = "fernandes";
         //emp.Pensja = 14000;
         //listaPrac.Add(emp);

         //emp = new Pracownik();
         //emp.Imie = "michael";
         //emp.Nazwisko = "jackson";
         //emp.Pensja = 16000;
         //listaPrac.Add(emp);

         //emp = new Pracownik();
         //emp.Imie = "robert";
         //emp.Nazwisko = "pattinson";
         //emp.Pensja = 20000;
         //listaPrac.Add(emp);

         //return listaPrac;
         #endregion
      }

      public StatusUzytkownika WalidujUzytkownika(Uzytkownik u)
      {
         if (u.NazwaUsera == "admin" && u.Haslo == "admin")
            return StatusUzytkownika.UwierzytelnionyAdmin;
         else if (u.NazwaUsera == "marek" && u.Haslo == "marek")
            return StatusUzytkownika.UwierzytelnionyUser;
         else
            return StatusUzytkownika.NieUwierzytelnionyUser;
      }

      //public bool IsValidUser(Uzytkownik u) {
      //   if (u.NazwaUsera == "Admin" && u.Haslo == "Admin")  
      //      return true;
      //   else
      //      return false;
      //}

   }
}