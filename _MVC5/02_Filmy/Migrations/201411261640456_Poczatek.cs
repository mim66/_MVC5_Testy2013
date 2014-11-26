namespace _02_Filmy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Poczatek : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Films", "Ocena");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "Ocena", c => c.String());
        }
    }
}
