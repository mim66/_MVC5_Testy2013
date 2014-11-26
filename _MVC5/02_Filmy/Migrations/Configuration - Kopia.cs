/*
namespace _02_Filmy.Migrations
{
   using _02_Filmy.Models;
   using System;
   using System.Data.Entity;
   using System.Data.Entity.Migrations;
   using System.Linq;

   internal sealed class Configuration : DbMigrationsConfiguration<_02_Filmy.Models.FilmyDBContext>
   {
      public Configuration()
      {
         AutomaticMigrationsEnabled = false;
         ContextKey = "_02_Filmy.Models.FilmyDBContext";
      }

      protected override void Seed(_02_Filmy.Models.FilmyDBContext context)
      {
         //  This method will be called after migrating to the latest version.

         //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
         //  to avoid creating duplicate seed data. E.g.
         //
         //    context.People.AddOrUpdate(
         //      p => p.FullName,
         //      new Person { FullName = "Andrew Peters" },
         //      new Person { FullName = "Brice Lambson" },
         //      new Person { FullName = "Rowan Miller" }
         //    );
         //
         context.Filmy.AddOrUpdate(i => i.Tytul,
             new Film
             {
                Tytul = "Kiedy Harry spotka³ Sally",
                DataWydania = DateTime.Parse("1989-1-11"),
                Kategoria = "Komedia Romantyczna",
                Ocena = "PG",
                Cena = 7.99M
             },

              new Film
              {
                 Tytul = "Ghostbusters ",
                 DataWydania = DateTime.Parse("1984-3-13"),
                 Kategoria = "Komedia",
                 Ocena = "PG",
                 Cena = 8.99M
              },

              new Film
              {
                 Tytul = "Ghostbusters 2",
                 DataWydania = DateTime.Parse("1986-2-23"),
                 Kategoria = "Komedia",
                 Ocena = "PG",
                 Cena = 9.99M
              },

            new Film
            {
               Tytul = "Rio Bravo",
               DataWydania = DateTime.Parse("1959-4-15"),
               Kategoria = "Western",
               Ocena = "PG",
               Cena = 3.99M
            }
        );
      }
   }
}
*/