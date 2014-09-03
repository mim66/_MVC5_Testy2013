namespace ContosoPl.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using ContosoPl.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<ContosoPl.Models.SzkolaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        //Enable-Migrations -ContextTypeName ContosoPl.Models.SzkolaContext
        //add-Migration Poczatek
        //update-database
        // wype³niono metodê Seed
        //update-database
        

        protected override void Seed(ContosoPl.Models.SzkolaContext context) {
            //var studenci = new List<Student>    {
            //        new Student { PierwszeImie = "Carson",  Nazwisko = "Alexander", DataNaboru = DateTime.Parse("2010-09-01") },
            //        new Student { PierwszeImie = "Meredith", Nazwisko = "Alonso",   DataNaboru = DateTime.Parse("2012-09-01") },
            //        new Student { PierwszeImie = "Arturo",  Nazwisko = "Anand",     DataNaboru = DateTime.Parse("2013-09-01") },
            //        new Student { PierwszeImie = "Gytis",   Nazwisko = "Barzdukas", DataNaboru = DateTime.Parse("2012-09-01") },
            //        new Student { PierwszeImie = "Yan",     Nazwisko = "Li",        DataNaboru = DateTime.Parse("2012-09-01") },
            //        new Student { PierwszeImie = "Peggy",   Nazwisko = "Justice",   DataNaboru = DateTime.Parse("2011-09-01") },
            //        new Student { PierwszeImie = "Laura",   Nazwisko = "Norman",    DataNaboru = DateTime.Parse("2013-09-01") },
            //        new Student { PierwszeImie = "Nino",    Nazwisko = "Olivetto",  DataNaboru = DateTime.Parse("2005-09-01") }
            //};
            //studenci.ForEach(s => context.Studenci.AddOrUpdate(p => p.Nazwisko, s));
            //context.SaveChanges();


            //var instruktorzy = new List<Instruktor>  {
            //    new Instruktor { PierwszeImie = "Kim",      Nazwisko = "Abercrombie", DataAngazu = DateTime.Parse("1995-03-11") },
            //    new Instruktor { PierwszeImie = "Fadi",     Nazwisko = "Fakhouri",  DataAngazu = DateTime.Parse("2002-07-06") },
            //    new Instruktor { PierwszeImie = "Roger",    Nazwisko = "Harui",     DataAngazu = DateTime.Parse("1998-07-01") },
            //    new Instruktor { PierwszeImie = "Candace",  Nazwisko = "Kapoor",    DataAngazu = DateTime.Parse("2001-01-15") },
            //    new Instruktor { PierwszeImie = "Roger",    Nazwisko = "Zheng",     DataAngazu = DateTime.Parse("2004-02-12") }
            //};
            //instruktorzy.ForEach(s => context.Instruktorzy.AddOrUpdate(p => p.Nazwisko, s));
            //context.SaveChanges(); 
            
            //var wydzialy = new List<Wydzial>{
            //    new Wydzial { Nazwa = "English",    Budzet = 350000,  DataPoczatkowa = DateTime.Parse("2007-09-01"), IdInstruktora = instruktorzy.Single( i => i.Nazwisko == "Abercrombie").Id },
            //    new Wydzial { Nazwa = "Mathematics", Budzet = 100000, DataPoczatkowa = DateTime.Parse("2007-09-01"), IdInstruktora = instruktorzy.Single( i => i.Nazwisko == "Fakhouri").Id },
            //    new Wydzial { Nazwa = "Engineering", Budzet = 350000, DataPoczatkowa = DateTime.Parse("2007-09-01"), IdInstruktora = instruktorzy.Single( i => i.Nazwisko == "Harui").Id },
            //    new Wydzial { Nazwa = "Economics",  Budzet = 100000,  DataPoczatkowa = DateTime.Parse("2007-09-01"), IdInstruktora = instruktorzy.Single( i => i.Nazwisko == "Kapoor").Id }
            //};
            //wydzialy.ForEach(s => context.Wydzialy.AddOrUpdate(p => p.Nazwa, s));
            //context.SaveChanges();

            ////var kursy = new List<Kurs>  {
            ////    new Kurs{Id=1050,Tytul="Chemia",Zaliczenia=3,},
            ////    new Kurs{Id=4022,Tytul="Mikroekonomia",Zaliczenia=3,},
            ////    new Kurs{Id=4041,Tytul="Makroekonomia",Zaliczenia=3,},
            ////    new Kurs{Id=1045,Tytul="Rachunki",Zaliczenia=4,},
            ////    new Kurs{Id=3141,Tytul="Trygonometria",Zaliczenia=4,},
            ////    new Kurs{Id=2021,Tytul="Kompozycja",Zaliczenia=3,},
            ////    new Kurs{Id=2042,Tytul="Literatura",Zaliczenia=4,}
            ////};
            ////kursy.ForEach(s => context.Kursy.Add(s));
            ////context.SaveChanges();

            //var kursy = new List<Kurs>{
            //    new Kurs {Id = 1050, Tytul = "Chemistry", Zaliczenia = 3, IdWydzialu = wydzialy.Single( s => s.Name == "Engineering").Id, Instruktorzy = new List<Instruktor>() },
            //    new Kurs {Id = 4022, Tytul = "Microeconomics", Zaliczenia = 3,IdWydzialu = wydzialy.Single( s => s.Name == "Economics").Id, Instruktorzy = new List<Instruktor>() },
            //    new Kurs {Id = 4041, Tytul = "Macroeconomics", Zaliczenia = 3,IdWydzialu = wydzialy.Single( s => s.Name == "Economics").Id, Instruktorzy = new List<Instruktor>() },
            //    new Kurs {Id = 1045, Tytul = "Calculus", Zaliczenia = 4,IdWydzialu = wydzialy.Single( s => s.Name == "Mathematics").Id, Instruktorzy = new List<Instruktor>() },
            //    new Kurs {Id = 3141, Tytul = "Trigonometry", Zaliczenia = 4,IdWydzialu = wydzialy.Single( s => s.Name == "Mathematics").Id, Instruktorzy = new List<Instruktor>() },
            //    new Kurs {Id = 2021, Tytul = "Composition", Zaliczenia = 3,IdWydzialu = wydzialy.Single( s => s.Name == "English").Id, Instruktorzy = new List<Instruktor>()  },
            //    new Kurs {Id = 2042, Tytul = "Literature", Zaliczenia = 4,IdWydzialu = wydzialy.Single( s => s.Name == "English").Id, Instruktorzy = new List<Instruktor>() }
            //};
            //kursy.ForEach(s => context.Kursy.AddOrUpdate(p => p.Id, s));
            //context.SaveChanges();

            //var przydzieloneBiura = new List<PrzydzieloneBiuro> {
            //    new PrzydzieloneBiuro { IdInstruktora = instruktorzy.Single( i => i.Nazwisko == "Fakhouri").Id, Adres = "Smith 17" },
            //    new PrzydzieloneBiuro { IdInstruktora = instruktorzy.Single( i => i.Nazwisko == "Harui").Id, Adres = "Gowan 27" },
            //    new PrzydzieloneBiuro { IdInstruktora = instruktorzy.Single( i => i.Nazwisko == "Kapoor").Id, Adres = "Thompson 304" },
            //};
            //przydzieloneBiura.ForEach(s => context.PrzydzieloneBiura.AddOrUpdate(p => p.IdInstruktora, s));
            //context.SaveChanges();


            //AddOrUpdateInstructor(context, "Chemistry", "Kapoor");
            //AddOrUpdateInstructor(context, "Chemistry", "Harui");
            //AddOrUpdateInstructor(context, "Microeconomics", "Zheng");
            //AddOrUpdateInstructor(context, "Macroeconomics", "Zheng");
            //AddOrUpdateInstructor(context, "Calculus", "Fakhouri");
            //AddOrUpdateInstructor(context, "Trigonometry", "Harui");
            //AddOrUpdateInstructor(context, "Composition", "Abercrombie");
            //AddOrUpdateInstructor(context, "Literature", "Abercrombie");
            //context.SaveChanges();

            //var nabory = new List<Nabor>{
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Alexander").Id, IdKursu = kursy.Single(c => c.Tytul == "Chemistry" ).IdKursu, Ocena = Ocena.A },
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Alexander").Id, IdKursu = kursy.Single(c => c.Tytul == "Microeconomics" ).IdKursu,  Ocena = Ocena.C },    
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Alexander").Id, IdKursu = kursy.Single(c => c.Tytul == "Macroeconomics" ).IdKursu, Ocena = Ocena.B},
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Alonso").Id,    IdKursu = kursy.Single(c => c.Tytul == "Calculus" ).IdKursu, Ocena = Ocena.B },
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Alonso").Id,    IdKursu = kursy.Single(c => c.Tytul == "Trigonometry" ).IdKursu, Ocena = Ocena.B },
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Alonso").Id, IdKursu = kursy.Single(c => c.Tytul == "Composition" ).IdKursu, Ocena = Ocena.B },    
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Anand").Id,    IdKursu = kursy.Single(c => c.Tytul == "Chemistry" ).IdKursu},
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Anand").Id,    IdKursu = kursy.Single(c => c.Tytul == "Microeconomics").IdKursu,Ocena = Ocena.B },
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Barzdukas").Id, IdKursu = kursy.Single(c => c.Tytul == "Chemistry").IdKursu,Ocena = Ocena.B },
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Li").Id,       IdKursu = kursy.Single(c => c.Tytul == "Composition").IdKursu,Ocena = Ocena.B },
            //    new Nabor { IdStudenta = studenci.Single(s => s.Nazwisko == "Justice").Id,  IdKursu = kursy.Single(c => c.Tytul == "Literature").IdKursu,Ocena = Ocena.B }
            //};
            //foreach (Nabor e in nabory) {
            //    var naborWBazie = context.Nabory.Where(s => s.Student.Id == e.IdStudenta && s.Kurs.Id == e.IdKursu).SingleOrDefault();
            //    if (naborWBazie == null) {
            //        context.Nabory.Add(e);
            //    }
            //}
            //context.SaveChanges();
        }

        //void AddOrUpdateInstructor(SzkolaContext context, string tytulKursu, string nazwaInstruktora) {
        //    var crs = context.Kursy.SingleOrDefault(c => c.Tytul == tytulKursu);
        //    var inst = crs.instruktorzy.SingleOrDefault(i => i.Nazwisko == nazwaInstruktora);
        //    if (inst == null)
        //        crs.instruktorzy.Add(context.Instruktorzy.Single(i => i.Nazwisko == nazwaInstruktora));
        //}
    }
}
