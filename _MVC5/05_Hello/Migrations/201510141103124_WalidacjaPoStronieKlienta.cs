namespace _05_Hello.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WalidacjaPoStronieKlienta : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblPracownicy", "Nazwisko", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblPracownicy", "Nazwisko", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
