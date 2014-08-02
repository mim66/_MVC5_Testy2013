namespace ContosoPolski.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ContosoPolski.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<ContosoPolski.Models.SzkolaContext>
    {
        public Configuration() {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ContosoPolski.Models.SzkolaContext context) {
            var studenci = new List<Student> 
            {
            new Student{PierwszeImie="Monika",  Nazwisko="Alexander",DataNaboru=DateTime.Parse("2005-09-01")},
            new Student{PierwszeImie="Marian",  Nazwisko="Alonso",  DataNaboru=DateTime.Parse("2002-09-01")},
            new Student{PierwszeImie="Artur",   Nazwisko="Anand",   DataNaboru=DateTime.Parse("2003-09-01")},
            new Student{PierwszeImie="Zbyszek", Nazwisko="Barzdukas",DataNaboru=DateTime.Parse("2002-09-01")},
            new Student{PierwszeImie="Jan",     Nazwisko="Li",      DataNaboru=DateTime.Parse("2002-09-01")},
            new Student{PierwszeImie="Tomek",   Nazwisko="Justice", DataNaboru=DateTime.Parse("2001-09-01")},
            new Student{PierwszeImie="Laura",   Nazwisko="Norman",  DataNaboru=DateTime.Parse("2003-09-01")},
            new Student{PierwszeImie="Nina",    Nazwisko="Olivetto",DataNaboru=DateTime.Parse("2005-09-01")}
            };

            studenci.ForEach(s => context.Studenci.Add(s));
            context.SaveChanges();
            var kursy = new List<Kurs>
            {
            new Kurs{Id=1050,Tytul="Chemistry",Zaliczenia=3,},
            new Kurs{Id=4022,Tytul="Microeconomics",Zaliczenia=3,},
            new Kurs{Id=4041,Tytul="Macroeconomics",Zaliczenia=3,},
            new Kurs{Id=1045,Tytul="Calculus",Zaliczenia=4,},
            new Kurs{Id=3141,Tytul="Trigonometry",Zaliczenia=4,},
            new Kurs{Id=2021,Tytul="Composition",Zaliczenia=3,},
            new Kurs{Id=2042,Tytul="Literature",Zaliczenia=4,}
            };
            kursy.ForEach(s => context.Kursy.Add(s));
            context.SaveChanges();
            var nabory = new List<Nabor>
            {
            new Nabor{IdStudenta=1,IdKursu=1050,Ocena=Ocena.A},
            new Nabor{IdStudenta=1,IdKursu=4022,Ocena=Ocena.C},
            new Nabor{IdStudenta=1,IdKursu=4041,Ocena=Ocena.B},
            new Nabor{IdStudenta=2,IdKursu=1045,Ocena=Ocena.B},
            new Nabor{IdStudenta=2,IdKursu=3141,Ocena=Ocena.F},
            new Nabor{IdStudenta=2,IdKursu=2021,Ocena=Ocena.F},
            new Nabor{IdStudenta=3,IdKursu=1050},
            new Nabor{IdStudenta=4,IdKursu=1050,},
            new Nabor{IdStudenta=4,IdKursu=4022,Ocena=Ocena.F},
            new Nabor{IdStudenta=5,IdKursu=4041,Ocena=Ocena.C},
            new Nabor{IdStudenta=6,IdKursu=1045},
            new Nabor{IdStudenta=7,IdKursu=3141,Ocena=Ocena.A},
            };
            nabory.ForEach(s => context.Nabory.Add(s));
            context.SaveChanges();
        }
    }
}
