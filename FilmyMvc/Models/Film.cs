using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FilmyMvc.Models
{
   public class FilmContext : DbContext {
      public FilmContext() : base("FilmyDB") {
         //Database.SetInitializer<FilmDBContext>(new DropCreateDatabaseIfModelChanges<FilmDBContext>());
			//Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestContext, CodeFirst_WithMigration.Migrations.Configuration>("EFTest"));
		}
	
      public DbSet<Film> Filmy { get; set; }
   }

   public class Film
   {
      public int        ID          { get; set; }

      [Required]
      public string     Tytul       { get; set; }
      
      [DataType(DataType.Date)]
      public DateTime   DataWydania { get; set; }

      [Required]
      public string Kategoria { get; set; }

      [Range(1, 100)]
      [DataType(DataType.Currency)]
      public decimal Cena { get; set; }
      
      [StringLength(5)]
      public string     Ocena       { get; set; }

   }
}