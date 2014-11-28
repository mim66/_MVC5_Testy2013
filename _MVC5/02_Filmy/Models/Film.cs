using System;
using System.ComponentModel.DataAnnotations;
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

      [StringLength(60,MinimumLength=3)]
      public string Tytul { get; set; }

      //[Display(Name = "Data Wydania")]
      //[DataType(DataType.Date)]
      [Display(Name = "Data Wydania"), DataType(DataType.Date)]
      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
      //[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
      //[Range(typeof(DateTime), "1/1/1966", "1/1/2020")]
      public DateTime DataWydania { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
      [Required]
      [StringLength(30)]
      public string Kategoria { get; set; }
      
      //[Range(1,100)]
      //[DataType(DataType.Currency)]
      [Range(1, 100),DataType(DataType.Currency)]
      public decimal Cena { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
      [StringLength(5)]
      public string Ocena { get; set; }
   }

   public class FilmyDBContext : DbContext
   {
      public DbSet<Film> Filmy { get; set;}
   }

}