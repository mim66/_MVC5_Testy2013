//using System;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Web;

namespace _05_Hello.Models
{
   public class Pracownik
   {
      [Key]
      public int PracId { get; set; }
      
      [Required(ErrorMessage="Proszę podać imię:")]
      public string Imie         { get; set; }

      [Required(ErrorMessage = "Proszę podać nazwisko:")]
      [StringLength(30, ErrorMessage = "Długość nazwiska nie może być większa niż 30 znaków.")]
      public string Nazwisko { get; set; }
      public int Pensja   { get; set; }
   }
}