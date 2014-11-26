namespace _02_Filmy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ocena : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Ocena", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Ocena");
        }
    }
}
