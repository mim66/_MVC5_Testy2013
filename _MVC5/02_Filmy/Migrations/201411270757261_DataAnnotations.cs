namespace _02_Filmy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "Tytul", c => c.String(maxLength: 60));
            AlterColumn("dbo.Films", "Kategoria", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Films", "Ocena", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "Ocena", c => c.String());
            AlterColumn("dbo.Films", "Kategoria", c => c.String());
            AlterColumn("dbo.Films", "Tytul", c => c.String());
        }
    }
}
