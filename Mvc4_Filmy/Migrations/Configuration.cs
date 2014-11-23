namespace MvcTest.Migrations
{
   using FilmyMvc.Models;
   using System;
   using System.Data.Entity;
   using System.Data.Entity.Migrations;
   using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FilmyMvc.Models.FilmContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FilmyMvc.Models.FilmContext context) {
           context.Filmy.AddOrUpdate(i => i.Tytul,
                  new Film {
                     Tytul = "Kiedy Harry spotka³ Sally",
                     DataWydania = DateTime.Parse("1989-1-11"),
                     Kategoria = "Komedia romantyczna",
                     Cena = 7.99M,
                     Ocena = "G"
                  },
                   new Film {
                      Tytul = "Ghostbusters ",
                      DataWydania = DateTime.Parse("1984-3-13"),
                      Kategoria = "Komedia",
                      Cena = 8.99M,
                      Ocena = "PG"
                   },
                   new Film {
                      Tytul = "Ghostbusters 2",
                      DataWydania = DateTime.Parse("1986-2-23"),
                      Kategoria = "Komedia",
                      Cena = 9.99M,
                      Ocena = "PG"
                   },
                 new Film {
                    Tytul = "Rio Bravo",
                    DataWydania = DateTime.Parse("1959-4-15"),
                    Kategoria = "Western",
                    Cena = 3.99M,
                     Ocena = "G"
                 }
             );
        }
    
    }
}
