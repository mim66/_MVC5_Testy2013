using System;
using System.Data.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;

namespace _02_Filmy.Models
{
   public class Film
   {
      public int ID { get; set; }

      public string Tytul { get; set; }

      public DateTime DataWydania { get; set; }

      public string Kategoria { get; set; }

      public decimal Cena { get; set; }

   }

   public class FilmyDBContext : DbContext
   {
      public DbSet<Film> Filmy { get; set;}
   }

}