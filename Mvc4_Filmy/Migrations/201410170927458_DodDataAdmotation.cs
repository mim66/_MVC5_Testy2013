namespace MvcTest.Migrations
{
   using System;
   using System.Data.Entity.Migrations;

   public partial class DodDataAdmotation : DbMigration
   {
      public override void Up() {
         AlterColumn("dbo.Films", "Tytul", c => c.String(nullable: false));
         AlterColumn("dbo.Films", "Kategoria", c => c.String(nullable: false));
         AlterColumn("dbo.Films", "Ocena", c => c.String(maxLength: 5));
      }

      public override void Down() {
         AlterColumn("dbo.Films", "Ocena", c => c.String());
         AlterColumn("dbo.Films", "Kategoria", c => c.String());
         AlterColumn("dbo.Films", "Tytul", c => c.String());
      }
   }
}
