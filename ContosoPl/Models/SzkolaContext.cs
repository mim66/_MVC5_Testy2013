using ContosoPl.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoPl.Models
{
    public class SzkolaContext : DbContext
    {
        public SzkolaContext() : base("SzkolaContext") {}

        public DbSet<Kurs>          Kursy { get; set; }
        public DbSet<Wydzial>       Wydzialy { get; set; }
        public DbSet<Nabor>         Nabory { get; set; }
        //public DbSet<Instruktor>    Instruktorzy { get; set; }
        public DbSet<Student>       Studenci { get; set; }
        public DbSet<PrzydzieloneBiuro> PrzydzieloneBiura { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Kurs>() 
            //    .HasMany(c => c.Instruktorzy).WithMany(i => i.Kursy)
            //    .Map(t => t.MapLeftKey("IdKursu")
            //    .MapRightKey("IdInstruktora")
            //    .ToTable("KursInstruktor"));

        }
    }
}