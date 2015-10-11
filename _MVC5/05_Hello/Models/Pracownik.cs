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
      
      // walidacja niestandardowa
      [Imie_Val]
      public string Imie         { get; set; }

      [Required(ErrorMessage = "Proszę podać nazwisko:")]
      [StringLength(30, ErrorMessage = "Długość nazwiska nie może być większa niż 30 znaków.")]
      public string Nazwisko { get; set; }
      public int Pensja   { get; set; }
   }
   
   public class Imie_Val: ValidationAttribute
   {
      protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
         if (value == null) {
            return new ValidationResult("Prosze podać imię:");
         }
         else {
            if (value.ToString().Contains("@")) {
               return new ValidationResult("Imię nie może zawierać znaku '@'...");
            }
         }
         return ValidationResult.Success;
      }
   }
}