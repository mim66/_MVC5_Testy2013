using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTest.Models
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
      public int        ID { get; set; }
      public string     Tytul { get; set; }
      public DateTime   DataWydania { get; set; }
      public string     Kategoria { get; set; }
      public decimal    Cena { get; set; }
   }
}