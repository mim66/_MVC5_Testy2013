using ContosoPolski.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoPolski.Models
{
    public class SzkolaContext : DbContext
    {
        public SzkolaContext() : base("SzkolaContext") {}
        
        public DbSet<Student> Studenci { get; set; }
        public DbSet<Nabor> Nabory { get; set; }
        public DbSet<Kurs> Kursy { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}