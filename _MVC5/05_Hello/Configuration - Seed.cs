//namespace _05_Hello.Migrations
//{
//    using System;
//    using System.Data.Entity;
//    using System.Data.Entity.Migrations;
//    using System.Linq;
//    using _05_Hello.Models;

//    internal sealed class Configuration : DbMigrationsConfiguration<_05_Hello.DAL.MvcHelloDB>
//    {
//        public Configuration()
//        {
//            AutomaticMigrationsEnabled = false;
//            ContextKey = "_05_Hello.DAL.MvcHelloDB";
//        }

//        protected override void Seed(_05_Hello.DAL.MvcHelloDB context)
//        {
//            //  This method will be called after migrating to the latest version.

//            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
//            //  to avoid creating duplicate seed data. E.g.
//            //
//            //    context.People.AddOrUpdate(
//            //      p => p.FullName,
//            //      new Person { FullName = "Andrew Peters" },
//            //      new Person { FullName = "Brice Lambson" },
//            //      new Person { FullName = "Rowan Miller" }
//            //    );
//            //

//           context.Pracownicy.AddOrUpdate(
//             p => p.PracId,
//             new Pracownik { Imie = "jonson", Nazwisko = "fernandes", Pensja = 14000 },
//             new Pracownik { Imie = "michael", Nazwisko = "jackson", Pensja = 16000 },
//             new Pracownik { Imie = "robert", Nazwisko = "pattinson", Pensja = 20000 }
//           );

//        }
//    }
//}
