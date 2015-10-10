namespace _05_Hello.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZmianyTblPrac : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblPracownicy", "Imie", c => c.String(nullable: false));
            AlterColumn("dbo.tblPracownicy", "Nazwisko", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblPracownicy", "Nazwisko", c => c.String());
            AlterColumn("dbo.tblPracownicy", "Imie", c => c.String());
        }
    }
}
