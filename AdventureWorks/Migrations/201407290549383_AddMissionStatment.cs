namespace AdventureWorks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMissionStatment : DbMigration
    {
        public override void Up()
        {
            AddColumn("HumanResources.Department", "MissionStatement", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("HumanResources.Department", "MissionStatement");
        }
    }
}
