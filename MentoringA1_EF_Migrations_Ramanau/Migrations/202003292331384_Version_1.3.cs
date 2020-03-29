namespace MentoringA1_EF_Migrations_Ramanau.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version_13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Foundation", c => c.DateTime());
            RenameTable("Regions", "Regionsss");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Foundation");
            RenameTable("Regionsss", "Regions");
        }
    }
}
