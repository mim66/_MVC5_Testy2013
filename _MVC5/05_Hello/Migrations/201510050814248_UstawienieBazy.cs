namespace _05_Hello.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UstawienieBazy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblPracownicy",
                c => new
                    {
                        PracId = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Pensja = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PracId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblPracownicy");
        }
    }
}
