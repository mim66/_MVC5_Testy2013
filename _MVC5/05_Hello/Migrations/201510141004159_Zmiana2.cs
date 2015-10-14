namespace _05_Hello.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Zmiana2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblPracownicy", "Pensja", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblPracownicy", "Pensja", c => c.Int());
        }
    }
}
