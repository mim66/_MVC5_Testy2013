namespace ContosoPl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kurs",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Tytul = c.String(),
                        Zaliczenia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nabor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdKursu = c.Int(nullable: false),
                        IdStudenta = c.Int(nullable: false),
                        Ocena = c.Int(),
                        Kurs_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kurs", t => t.Kurs_Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .Index(t => t.Kurs_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwisko = c.String(),
                        PierwszeImie = c.String(),
                        DataNaboru = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nabor", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.Nabor", "Kurs_Id", "dbo.Kurs");
            DropIndex("dbo.Nabor", new[] { "Student_Id" });
            DropIndex("dbo.Nabor", new[] { "Kurs_Id" });
            DropTable("dbo.Student");
            DropTable("dbo.Nabor");
            DropTable("dbo.Kurs");
        }
    }
}
