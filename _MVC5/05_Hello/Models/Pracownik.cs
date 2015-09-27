using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _05_Hello.Models
{
   public class Pracownik
   {
      [Key]
      public int PracId { get; set; }
      public string Imie         { get; set; }
      public string Nazwisko     { get; set; }
      public int Pensja   { get; set; }
   }
}