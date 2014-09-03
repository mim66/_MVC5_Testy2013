namespace ContosoPl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthOnNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "Nazwisko", c => c.String(maxLength: 50));
            AlterColumn("dbo.Student", "PierwszeImie", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "PierwszeImie", c => c.String());
            AlterColumn("dbo.Student", "Nazwisko", c => c.String());
        }
    }
}
